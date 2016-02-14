/*!
 * Вспомогательные методы Knockout JavaScript library
 * (c) Бабарыкин Евгений.
 * License: MIT (http://www.opensource.org/licenses/mit-license.php)
 */

// Проверка текста на существование.
// Если текст не существует, то возвращаем пустую строку.
window.checkText = function (text) {
	return text != null && text != 'undefined' ? text : '';
};

// Проверка существования объекта.
window.isNull = function (object) {
	return object == null || object == 'undefined' || object == '';
};

// Преобразование даты из строки в объект (формируется при сериализации на сервере).
window.toJavaScriptDate = function (value) {
	var pattern = /Date\(([^)]+)\)/;
	var results = pattern.exec(value);
	if (!results) return value;
	var dateTime = new Date(parseFloat(results[1]));
	var day = dateTime.getDate() < 10 ? ('0' + dateTime.getDate()) : (dateTime.getDate() + '');
	var month = dateTime.getMonth() < 9 ? ('0' + (dateTime.getMonth() + 1)) : ((dateTime.getMonth() + 1) + '');
	return day + "." + month + "." + dateTime.getFullYear();
}

// Запрос.
// uri - адрес запроса.
// method - метод HTTP запроса (GET, POST).
// data - передаваемые данные.
// callback - обработчик ответа запроса.
// error - обработчик ошибки запроса.
window.jsonRequest = function (uri, method, data, callback, error) {
	$.ajax({ url: uri, type: method, contentType: 'application/json; charset=utf-8', data: JSON.stringify(data) }).done(callback).fail(error);
};

// Запрос.
// uri - адрес запроса.
// method - метод HTTP запроса (GET, POST).
// data - передаваемые данные.
// callback - обработчик ответа запроса.
// error - обработчик ошибки запроса.
window.request = function (uri, method, data, callback, error) {
	$.ajax({ type: method, url: uri, data: data }).done(callback).fail(error);
};

// Логирование.
window.logger = {
	// Логирование текста.
	log: function (text) {
		window.console && window.console.log(text);
	},
	// Логирование объекта.
	// text - некоторый текст сописанием.
	// data - логируемый объект.
	data: function (text, data) {
		if (data != null && data != 'undefined') {
			window.console && window.console.log(text);
			window.console && window.console.log(data);
		}
	},
	// Логирование ошибки.
	// exception - javaScript исключение.
	error: function (exception) {
		exception && exception.responseJSON && exception.responseJSON.message && window.console && window.console.log('message: ' + exception.responseJSON.message);
		exception && exception.responseJSON && exception.responseJSON.messageDetail && window.console && window.console.log('messageDetail: ' + exception.responseJSON.messageDetail);
		exception && exception.status && window.console && window.console.log('status: ' + exception.status);
		exception && exception.statusText && window.console && window.console.log('statusText: ' + exception.statusText);
	}
}