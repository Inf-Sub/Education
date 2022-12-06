class GameManager:
    '''
    This class is designed to manage chats and dice in them.
    '''
    def __init__(self) -> None:
        self.chat_id = self._get_chat_id()
        pass

    def _set_gamers(self, user_id: int) -> None:
        pass

    def _set_round(self, round_number: int = 1) -> None:
        pass

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
    print(f"{'=' * 30}\nИниацилизация класса: ConfigReader")
    def __init__(self, config_files: tuple = ('.env', '.config')) -> None:
        '''
        The class constructor calls the _get_config_file() method to populate the class properties
        from the configuration files.
        '''
        print(f"{'=' * 30}\nИниацилизация конструктора класса: ConfigReader")
        self.api = {}

        if config_files != ():
            for config_file in config_files:
                self._get_config_file_path(config_file)
        else:
            print('config_files is empty')
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
            print(f"File: {config_file_path} is not found!")

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
        print(f"{'=' * 30}\nLoad config file: {config_file}")

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
    print(f"{'=' * 30}\nИниацилизация класса: TelegramBotAPI")

    def __init__(self, api_url: str, api_key: str) -> None:
        '''
        Запросить данные из API
        :param config: object with parameters for API
        :return:
        '''
        print(f"{'=' * 30}\nИниацилизация конструктора класса: TelegramBotAPI")
        # import fake_useragent as fua
        # import math

        self._chat_id = ''
        if api_url and api_key:
            self._tg_api_url = api_url + api_key
        #    self._api_url = api_url
        #    self._api_key = api_key
        else:
            print(f"{'=' * 30}\nError API data:\napi_url: {api_url}\napi_key: {api_key}")
            return

        print(f"{'=' * 30}\nПолучен URL API with API Key:\ntg_api_url: {self._tg_api_url}")


        # fake useragent
        #fake_ua = fua.UserAgent()
        #try:
        #    user_agent = fake_ua.random
        #except:
        #    user_agent = 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/105.0.0.0 Safari/537.36'
        

        self._headers = {
        #    'User-Agent': user_agent,
            'Accept-Language': 'ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7'
        }

    def get_updates(self) -> None:    
        ### imports ###
        import requests as req

        request_result = req.get(self._tg_api_url + '/getUpdates', headers=self._headers #, params=api_requests[key_req]['params']
        )

        if request_result.status_code != 200:
            print(f"Error: request status code == {request_result.status_code}")
            return
        else:
            print(
                f"{'=' * 30}\n" \
                f"Status code:   {request_result.status_code}\n" \
                f"Encoding:      {request_result.encoding}\n" \
                f"Headers:       {request_result.headers}\n" \
            )

        api_data = request_result.json()
        print(f"{'=' * 30}\n{api_data}")

        # выйти из текущей интерации цикла (временно return)
        if api_data['result'] is None:
            return
        else:
            return api_data

        # incorrectly
        if self._chat_id is None:
            self._chat_id = api_data['result']['message']['chat']['id']




def main():
    print(f"{'=' * 30}\nСкрипт запущен как: {__name__}")
    current_config = ConfigReader()
    print(f"{'=' * 30}\nПолучены данные из конфига:\nAPI: {current_config.api}")
    tg_bot_dice = TelegramBotAPI(
        current_config.api['api_url'],
        current_config.api['api_key']
    )

    tg_bot_dice.get_updates()


    #chat_id = tg_bot_dice.get_updates()
    #locals()['tg_chat' + chat_id]


if __name__ == "__main__":
    main()
