// regexobj.js

var email = "";
var phone = "";
var emailRegex = /^\w[-._\w]*\w@\w[._\w]*\w\.\w{2,8}$/;
var phoneRegex = /^\(?(\d{3})\)?[ -.](\d{3})[ -.](\d{4})$/;

function getEmail() {
	email = prompt("Enter your email:");
	
	if (email.match(emailRegex)) {
		return "Nice job! The email address you submitted was " + email + ".";
		
	}
	
	return "Sorry that is not a validly formatted email address.";
}

function getPhone() {
	phone = prompt("Enter your phone number:");
	
	if (phone.match(phoneRegex)) {
		return "Nice job! The phone number you submitted was " + phone + ".";
		
	}
	
	return "Sorry that is not a validly formatted phone number.";
}