var o = {
	// ������� ������ �� ������ Scripting.FileSystemObject
	fso:	new ActiveXObject('Scripting.FileSystemObject'),
	// ��������� ������ �� ������ WshShell
	wss:	new ActiveXObject('WScript.Shell'),
	// WScript
	wsh:	WSH
	// ���� �� �������� WSH �������� �� WScript
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





var arr = [1,2,3,4,15,6,7];
var len = arr.length;
var min = 0;
var max = 0;
var sum = 0;
while (len--){
	if(arr[len] > arr[max]){
		max = len;
	}else if(arr[len] < arr[min]){
		min = len;
	};
	//sum += arr[len];
	//console.log(len +' '+ sum);
};

//sum -= (arr[min] + arr[max]);

alert('MAX: '+ arr[max] +'\r\nMIN: '+ arr[min] +'\r\nSUM: '+ sum);


//arr = newArr;
/*
print_r(arr);
print_r(max);
print_r(min);

*/

