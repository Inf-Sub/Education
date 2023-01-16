var o = {
	// создаем ссылку на объект Scripting.FileSystemObject
	fso:	new ActiveXObject('Scripting.FileSystemObject'),
	// формируем ссылку на объект WshShell
	wss:	new ActiveXObject('WScript.Shell'),
	// WScript
	wsh:	WSH
	// если не работает WSH заменить на WScript
	//	wsh:	WScript
};


//function alert(<Text>)
//function alert(s){confirm(s);}; //o.wsh.Echo(s)
function alert(s){o.wsh.Echo(s);};


// function print_r (temporary utils)
function print_r(variable, deep, index) {
	if (variable===null) {var variable = 'null';}
	if (deep===undefined) {var deep = 0;}
	if (index===undefined) {var index = '';} else {index+=': ';}
	var mes = ''; var i = 0; var pre = '\n';
	while (i<deep) {pre+='\t'; i++;}
	if (variable && variable.nodeType!=undefined) {
		mes+=pre+index+'DOM node'+((variable.nodeType==1)? (' <'+variable.tagName+'>'): '');
	}else if (typeof(variable)=='object') {
		mes+=pre+index+' {';
		for(index in variable) {
			if (!variable.hasOwnProperty(index)){continue};
			mes+=print_r(variable[index], (deep+1), index);
		}
		mes+=pre+'}';
	} else {
		mes+=pre+index+variable;
	}
	if (deep) {return mes;} else {alert(mes);}
	//if (!deep){mes=mes.trim();if(!f_cLog(mes)){alert(mes);};};
	return mes;
};



//var 1
var arr = [1,2,3,4,5,6,7,8];
var len = arr.length;
var i = 0;
var newArr = [];
while(len--){
	newArr[i++] = arr[len];
};
arr = newArr;
print_r(arr);

//var 2
var arr = [1,2,3,4,5,6,7,8];
var len = arr.length;
var i = 0;
var temp = '';
//var newArr = [];
for (i=0; i < len/2; i++){
	temp = arr[i];
	arr[i] = arr[len - i - 1];
	arr[len - i - 1] = temp;
	//print_r(arr);
};
print_r(arr);



//arr = newArr;
/*
print_r(arr);
print_r(max);
print_r(min);

*/

