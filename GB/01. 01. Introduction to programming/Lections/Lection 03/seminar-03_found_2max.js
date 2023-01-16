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





var arr = [-100,-25,-6,-71,-83,-4,-7];
var len = arr.length;
var i;
var first_max = arr[0];
var second_max = arr[1]; // = ''
for (i = 0; i < len; i++){
	if(arr[i] > first_max){
		second_max = first_max;
		first_max = arr[i];
	}else if(arr[i] < first_max && arr[i] > second_max){
		second_max = arr[i];
	};
};

alert(first_max +'\r\n'+ second_max);


//arr = newArr;
/*
print_r(arr);
print_r(max);
print_r(min);

*/

