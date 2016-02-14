function toDoViewModel(links) {
	var self = this;

	var tokenKey = 'accessToken';

	self.result = ko.observable();
	self.user = ko.observable();
	self.links = ko.observable(links);
	self.page = ko.observable();

	self.registerEmail = ko.observable();
	self.registerPassword = ko.observable();
	self.registerPassword2 = ko.observable();

	self.loginEmail = ko.observable();
	self.loginPassword = ko.observable();

	// Обработка ошибки.
	function error(result) {
		self.result(result.status + ': ' + result.statusText);
	}

	// Регистрация нового пользователя.
	self.register = function () {
		self.result('');
		jsonRequest(self.links().register, 'POST', {
			Email: self.registerEmail(),
			Password: self.registerPassword(),
			ConfirmPassword: self.registerPassword2()
		}, function (data, a, b) {
			self.result("Done!");
		}, error);
		self.goToPage('Login')
	}

	// Вход.
	self.login = function () {
		self.result('');
		request(self.links().login, 'POST', {
			grant_type: 'password',
			username: self.loginEmail(),
			password: self.loginPassword()
		}, function (data, a, b) {
			self.user(data.userName);
			sessionStorage.setItem(tokenKey, data.access_token);
			self.goToPage('Home')
		}, error);
	}

	// Выход.
	self.logout = function () {
		self.user('');
		sessionStorage.removeItem(tokenKey)
		self.goToPage('Login')
	}

	self.goToPage = function (page) {
		self.page(page);
	};

	self.goToHome = function () {
		if (isNull(self.user()))
			self.goToPage('Login');
		else
			self.goToPage('Home');
	};

	self.goToRegister = function () {
		self.logout();
		self.goToPage('register');
	};

	self.goToLogin = function () {
		self.logout();
		self.goToPage('Login');
	};

	self.goToPage('Login')
	$('#section_content').show();
	$('#main_navbar').show();
}