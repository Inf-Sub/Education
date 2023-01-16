function SelectionSort(array){
	var rn = '\r\n';
	var log = '';
	for (var i = 0; i < array.length - 1; i++){
		var minPosition = i;
		log += rn +  'array: ['+ array.join(',') +'] | minPosition: ' + minPosition +' | '+ array[minPosition] + rn;
		for (var j = i + 1; j < array.length; j++){
			//log += 'i: '+ i +' j: '+ j + ' array['+ j + ']: '+ array[j] +' array['+ minPosition +']: '+ array[minPosition] + rn;
			log += 'i: '+ i +' j: '+ j + ' | '+ array[j] +' ? '+ array[minPosition] + rn;
			if (array[j] < array[minPosition]){
				minPosition = j;
				//log += array[j] +' < '+ array[minPosition]  + ' : minPosition: ' + array[minPosition] + rn;
				log += 'i: '+ i +' j: '+ j +' | '+ array[j] +' < '+ array[minPosition]  + ' : minPosition: ' + minPosition +' | '+ array[minPosition] + rn;
			}
		}
		var temporary = array[i];
		log += rn + '['+ array.join(',') +'] | i: '+ i + ' array['+ i + ']: '+ array[i] +' <=> array['+ minPosition +']: '+ array[minPosition] + rn;
		array[i] = array[minPosition];
		array[minPosition] = temporary;
		log += '['+ array.join(',') +'] | i: '+ i + ' array['+ i + ']: '+ array[i] +' array['+ minPosition +']: '+ array[minPosition] + rn;
	}
	return log;
}

var a = [56, 54, 76, 34, 84, 43, 10];

var b = SelectionSort(a);
var rn = '\r\n';

WScript.Echo(b);