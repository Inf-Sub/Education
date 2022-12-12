class GameManager:
    '''
    In order for the bot to see Dice in the Telegram group in the @BotFather settings, 
    you need to change /setprivace to disabled.

    This class is designed to manage chats and cubes in them.
    For each chat, we create a separate object, initialize the round, and add players 
    until the round is completed.
    If there are several winners, then we announce the next round, in which only the 
    winners of the previous round play. Until only one remains.

    Найти максимальное значение в словаре:
    https://ru.stackoverflow.com/questions/759476/%D0%BD%D0%B0%D0%B9%D1%82%D0%B8-%D0%BC%D0%B0%D0%BA%D1%81%D0%B8%D0%BC%D0%B0%D0%BB%D1%8C%D0%BD%D0%BE%D0%B5-%D0%B7%D0%BD%D0%B0%D1%87%D0%B5%D0%BD%D0%B8%D0%B5-%D1%81%D0%BB%D0%BE%D0%B2%D0%B0%D1%80%D1%8F-python
    '''

    """ def __init__(self, chat_id: int) -> None:
        if not chat_id is None:
            self.chat_id = chat_id
        else:
            print(f"Error: Incorrect telegram Chat ID")
            return
        
        self.gamers = self._set_gamers()
        self.round = self._set_game_round() """


    def __init__(self, config: dict) -> None:
        self.debug = True

        if self.debug:
            print(f"{'=' * 30}\nИниацилизация конструктора класса: GameManager\n")
        
        import time

        self._status = {}
        self._botmsg = self._set_bot_messages()

        i = 0
        while i < 1:
            i += 1
            tg_data = TelegramBotAPI(
                config['api_url'],
                config['api_key']
            )

            time.sleep(1)

            if len(tg_data.data) == 0:
                continue
            else:                
                # Write log to File.
                import json
                with open('TG-MSG.log', 'a') as outfile:
                    json.dump(tg_data.data, outfile, indent=5)

                if self.debug:
                    print(f"{'=' * 30}\nLenght: {len(tg_data.data)}\n")

            for new_msg in tg_data.data:
                if self.debug:
                    print(f"{'=' * 30}\nTelegram New Message:\n{new_msg}\n")

                if new_msg.get('message'):

                    tg_chat_id = new_msg['message']['chat']['id']
                    tg_user_id = new_msg['message']['from']['id']
                    #tg_username = new_msg['message']['from']['username']
                else:
                    if self.debug:
                        print(f"{'=' * 30}\n=== Continue===\n\n")
                    continue


                


                # Create Chat_ID list in status
                if tg_chat_id not in self._status:
                    #self._status[tg_chat_id] = {'users': {}, 'round': 1}
                    self._status[tg_chat_id] = [{'users': {}}]

                # Game round number
                round = len(self._status[tg_chat_id]) - 1
                if self.debug:
                    print(f"{'=' * 30}\nGame round number: {round}\n")
                
                if new_msg['message'].get('dice'):
                    if self.debug:
                        print(f"{'=' * 30}\n" \
                            #f"Telegram New Message:\n{new_msg}\n" \
                            #f"Type Telegram New Message: {type(new_msg)}\n" \
                            #f"Update ID: {new_msg['update_id']} Type: {type(new_msg['update_id'])}\n"
                            f"Dice Value: {new_msg['message']['dice']['value']}\n"
                        )

                    if tg_user_id not in self._status[tg_chat_id][round]['users']:
                        self._status[tg_chat_id][round]['users'][tg_user_id] = {
                            'username': new_msg['message']['from']['username'],
                            'value': new_msg['message']['dice']['value']
                        }
                    else:                        
                        if self.debug:
                            print(f"{'=' * 30}\n" \
                                f"You already rolled the die, rolled: " \
                                f"{self._status[tg_chat_id][round]['users'][tg_user_id]['value']}\n"
                                )
                        
                        tg_data.send_message({
                            'chat_id': tg_chat_id, 
                            'text': f"<b>You already rolled the die, rolled: " \
                                    f"{self._status[tg_chat_id][round]['users'][tg_user_id]['value']}</b>",
                            'parse_mode': 'html'
                            })


                if new_msg['message'].get('text'):
                    if self.debug:
                        print(f"{'=' * 30}\n" \
                            #f"Telegram New Message:\n{new_msg}\n" \
                            #f"Type Telegram New Message: {type(new_msg)}\n" \
                            #f"Update ID: {new_msg['update_id']} Type: {type(new_msg['update_id'])}\n"
                            f"Message Text: {new_msg['message']['text']}\n"
                    )

                    tg_msg_text = new_msg['message']['text']
                    
                    if self._botmsg.get(tg_msg_text):
                        tg_data.send_message({
                            'chat_id': tg_chat_id, 
                            'text': f"{self._botmsg[tg_msg_text]}",
                            'parse_mode': 'html'
                            })


                    

            else:
                tg_data.get_updates({'offset': new_msg['update_id'] + 1})



                
            if self.debug:
                print(f"{'=' * 30}\nSTATUS: {self._status}\n")

        #tg_bot_dice.get_updates()
        
        #self._chat_id = self._data[0]['message']['chat']['id']
        #print(f"{'=' * 30}\nTelegram Chat ID: {self._chat_id}")
        
    def _set_bot_messages(self) -> list:
        msg_list = {}

        msg_list['/info'] = f"<b><u>Dice Bot</u></b> version: 0.3.5 alpha\n" \
                            f"\n" \
                            f"<i>Shit Coding by @InfSub</i>\n" 

        msg_list['/help'] = f"<b><u>Помощь по использованию бота:</u></b>\n" \
                            f"\n" \
                            f"<b><u>Бросок кубика</u></b>\n" \
                            f"Что бы кинуть кубик, нажми на чужой и <b>Отправить</b>.\n" \
                            f"Если чужих кубиков нет, ты можешь отправить эмодзи 🎲 и Телеграм сделает из этого бросок кубика.\n" \
                            f"Чтобы поставить 🎲, напиши <b>:кубик</b> (<i><b>:dice</b> если язык Телеграма - английский</i>).\n" \
                            f"На веб-версии Телеграма кубики не работают.\n" \
                            f"\n" \
                            f"<b><u>Ход игры</u></b>\n" \
                            f"Первый раунд - кто угодно может кинуть кубик.\n" \
                            f"Начать игру и завершить раунд может только админ или сам бот.\n" \
                            f"В конце каждого раунда те игроки, у которых наибольшее количество очков, попадают в следующий раунд.\n" \
                            f"Во втором и последующих раундах могут участвовать только победители предыдущего раунда.\n" \
                            f"С 1:00 МСК по 7:00 МСК бот спит и не реагирует на команды и кубики.\n" \
                            f"\n" \
                            f"<b><u>Команды</u></b>\n" \
                            f"<s>Тебе доступны три команды:</s>\n" \
                            f"/info - Информация о боте.\n" \
                            f"/help - Отправляет это обучение, ты её уже, видимо, знаешь.\n" \
                            f"/stats - Отправляет список игроков раунда, там можно посмотреть кто участвует и кто сколько выкинул.\n" \
                            f"\n" \
                            f"<b><u>Команды для админов</u></b>\n" \
                            f"<s>Эти команды могут выполнять только админы, прости уж.</s>\n" \
                            f"/begin - Начинает игру. Бот не даст запустить новую игру, если старая ещё не закончена.\n" \
                            f"/next - Начинает следующий раунд, если победителей текущего несколько или заканчивает игру, " \
                            f"если победитель только один.\n" \
                            f"/next_force - Принудительно закончить раунд (без подтверждения).\n" \
                            f"<s>/revoke - Отправь в ответ на кубик игрока что бы обнулить его счёт в текущем раунде.</s>\n" \
                            f"\n" \
                            f"\n" \
                            f"И самое главное: не забывайте кидать репу Жанне. 😉"
        
        msg_list['/stats'] = f"<b><u>Dice Bot</u></b> version: 0.3.5 alpha\n" \
                            f"\n" \
                            f"<i>Shit Coding by @InfSub</i>\n" 
        
        msg_list['/begin'] = f"<b>❗️ Кидаем кубик 🎲</b>\n" \
                             f"<b>Победителю приз 🎉</b>\n" \
                            f"\n" \
                            f"Чтобы кинуть кубик, нажмите на него и затем на кнопку \"<b>Отправить</b>\".\n" 
        
        msg_list['/next'] = f"<b>Ты уверен(а), что хочешь закончить первый раунд?</b>\n" \
                            f"\n" \
                            f"/confirm - Да, уверен(а).\n" \
                            f"/cancel - Нет, отмена.\n" 

                            
        msg_list['next_round'] = f"<b>🎉 Победители 🎉 %s раунда со счётом %s:</b>\n" \
                            f"%s\n" \
                            f"\n" \
                            f"<b>❗️ Начинается раунд %s ❗️</b>\n" \
                            f"Кидайте кубики, товарищи победители!\n"

        msg_list['next_round_quote'] = f"<i>Жизнь измеряется не количеством наших вдохов, а количеством моментов, " \
                            f"от которых перехватывает дыхание.</i>\n" \
                            f"<i>— Майя Энджелоу</i>"

        msg_list['not_run'] = f"<b>Игра не запущена в данный момент</b>\n" 

        msg_list['/reload'] = f"<b>I'll be back...</b>\n"
        
        msg_list['/restart'] = f"<b>I'll be back...</b>\n"
        
        msg_list['/exit'] = f"<b>You killed me!!!</b>\n"



        return msg_list
                    

    def _get_command(self, msg):
        pass

    def _get_dice(self, msg):
        pass

    def _set_gamers(self, user_id: int) -> None:
        pass

    def _set_game_round(self, game_round_number: int = 1) -> int:
        return game_round_number + 1

    def _get_chat_id(self) -> int:
        pass



class ConfigReader:
    '''
    This class returns the program settings from the .config and .env files necessary for operation
    Russian: при инициализации, класс должен читать .config и получать от туда расположение .env 
    с приватными параметрами, в случае, если путь до .env пуст, читать .env из корня директории проекта
    класс должен вызывать метод get_config(path='') для чтения и установки свойств (если не найден .env 
    выдать ошибку / запрос на указание расположения .env) если свойств нет - вызываем методы 
    get_config() и get_env() иначе отдаем свойства
    '''

    def __init__(self, config_files: tuple = ('.env', '.config')) -> None:
        '''
        The class constructor calls the _get_config_file() method to populate the class properties
        from the configuration files.
        '''
        self.debug = False
        if self.debug:
            print(f"{'=' * 30}\nИниацилизация конструктора класса: ConfigReader\n")
        
        self.api = {}

        if config_files != ():
            for config_file in config_files:
                self._get_config_file_path(config_file)
        else:
            if self.debug:
                print(f"{'=' * 30}\nconfig_files is empty\n")
            # add Error message
            return


    def _get_config_file_path(self, config_file: str) -> None:
        '''
        This method checks for the presence of a file in the current project directory and passes
        it to the _get_config_file() method to get the class parameters
        :param config_file:
        :return:
        '''
        import os
        # for compatibility with jupyter notebook (name '__file__' is not defined)
        try:
            config_file_path = os.path.join(os.path.dirname(__file__), config_file)
        except:
            # dotenv_path = os.path.join(os.path.dirname(os.path.abspath('')),config_file)
            config_file_path = os.path.join(os.path.abspath(''), config_file)

        if os.path.exists(config_file_path):
            self._get_config_file(config_file_path)
        else:
            # Вывести в виде ошибки!
            if self.debug:
                print(f"{'=' * 30}\nFile: {config_file_path} is not found!\n")

    def _get_config_file(self, config_file: str = '') -> None:
        """
        This method reads private values from .env file and values from .config file.
        For install "dotenv" in "Python" use command:

        pip3 install python-dotenv
        For install "dotenv" in "Anaconda" use command:

        conda install -c conda-forge python-dotenv

        :param config_file: full path to config file
        :return: None
        """
        import os
        from dotenv import load_dotenv

        # load config file
        load_dotenv(config_file)
        if self.debug:
            print(f"{'=' * 30}\nLoad config file: {config_file}\n")

        # TODO: create a tuple or list, or dist of parameters and loop through them, checking and substituting
        #  an empty value if there is no parameter

        if os.getenv('api_key') is not None:
            self.api['api_key'] = os.getenv('api_key')
        if os.getenv('api_url') is not None:
            self.api['api_url'] = os.getenv('api_url')



class TelegramBotAPI:
    '''
    This class is for getting data from API
    '''

    def __init__(self, api_url: str, api_key: str) -> list:
        '''
        Запросить данные из API
        :param config: object with parameters for API
        :return:
        '''
        self.debug = False

        if self.debug:
            print(f"{'=' * 30}\nИниацилизация конструктора класса: TelegramBotAPI\n")
        # import fake_useragent as fua
        # import math

        if api_url and api_key:
            self._tg_api_url = api_url + api_key
        #    self._api_url = api_url
        #    self._api_key = api_key
        else:
            if self.debug:
                print(f"{'=' * 30}\nError API data:\napi_url: {api_url}\napi_key: {api_key}\n")

            return

        if self.debug:
            print(f"{'=' * 30}\nПолучен URL API with API Key:\ntg_api_url: {self._tg_api_url}\n")

        self._headers = {
        #    'User-Agent': user_agent,
            'Accept-Language': 'ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7',
            'ContentType': 'application/json; charset=utf-8'
        }

        self.data = self.get_updates()
        
        if self.debug:
            print(f"{'=' * 30}\nTelegram API Data: {type(self.data)}\n{self.data}\n")

        #self._chat_id = self._data[0]['message']['chat']['id']
        #print(f"{'=' * 30}\nTelegram Chat ID: {self._chat_id}")




        # fake useragent
        #fake_ua = fua.UserAgent()
        #try:
        #    user_agent = fake_ua.random
        #except:
        #    user_agent = 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/105.0.0.0 Safari/537.36'
        


    def get_updates(self, params: list = {}) -> list:
        ### imports ###
        import requests as req

        request_result = req.get(self._tg_api_url+'/getUpdates', headers=self._headers, params=params)

        if request_result.status_code != 200:
            if self.debug:
                print( f"{'=' * 30}\nError:\ngetUpdates: request status code == {request_result.status_code}\n")

            return
        else:
            if self.debug:
                print(
                    f"{'=' * 30}\n" \
                    f"getUpdates:\n" \
                    f"Status code:   {request_result.status_code}\n" \
                    f"Encoding:      {request_result.encoding}\n" \
                    f"Headers:       {request_result.headers}\n" \
                )

        api_data = request_result.json()
        if self.debug:
            print(f"{'=' * 30}\ngetUpdates: API Data:\n{api_data}\n")

        # for test getChatAdministrators
        #request_result = req.get(self._tg_api_url+'/getChatAdministrators', headers=self._headers, params={'chat_id': -862538827})
        #print(f"request_result: {request_result.json()}")

        # выйти из текущей интерации цикла (временно? return)
        if api_data['result'] is None:
            return
        else:
            if self.debug:
                print(f"{'=' * 30}\ngetUpdates: Result Type: {type(api_data['result'])}\n")
            
            return api_data['result']

        # incorrectly
        #if self._chat_id is None:
        #    self._chat_id = api_data['result']['message']['chat']['id']

    def send_message(self, data: list) -> None:
        self.debug = True
        ### imports ###
        import requests as req

        if not data.get('parse_mode'):
            data['parse_mode'] = 'html'

        request_result = req.post(self._tg_api_url+'/sendMessage', headers=self._headers, json=data)
   

        if self.debug:
            print(
                f"{'=' * 30}\n" \
                f"sendMessage:\n" \
                f"Status code:   {request_result.status_code}\n" \
                f"Encoding:      {request_result.encoding}\n" \
                f"Headers:       {request_result.headers}\n" \
                f"Text:          {request_result.text}\n" \
            )

        if request_result.status_code != 200:
            print(f"{'=' * 30}\n" \
                f"\Error:\n"
                f"sendMessage: request status code == {request_result.status_code}\n"
                f"Text: {request_result.text}\n")
            return


        self.debug = False



def main():
    debug = False

    if debug:
        print(f"{'=' * 30}\nСкрипт запущен как: {__name__}\n")
    
    current_config = ConfigReader()
    if debug:
        print(f"{'=' * 30}\nПолучены данные из конфига:\nAPI: {current_config.api}\nType: {type(current_config.api)}")
    
    GameManager(current_config.api)
    


    #chat_id = tg_bot_dice.get_updates()
    #locals()['tg_chat' + chat_id]


#tg_chat_id = 1590508723 // chat_id legion
if __name__ == "__main__":
    main()
