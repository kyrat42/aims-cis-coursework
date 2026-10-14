// bmass.js

var Bmi = {
	Weight : 0,
	Height : 0,
	
	inputs : function() {
		Bmi.Height = Number(prompt("Enter your height in inches:"));
		Bmi.Weight = Number(prompt("Enter your weight in pounds:"));
		
		Bmi.calc_bmi();
	},
	
	calc_bmi : function() {
		weightKilo = Bmi.Weight / 2.2;
		heightMeter = Bmi.Height / 39.37;
		
		bmi = weightKilo / Math.pow(heightMeter, 2);
		
		output = "<h2>My Body Mass Index</h2>\n";
		output += "<p>Height: " + Bmi.Height + " inches</p>";
		output += "<p>Weight: " + Bmi.Weight + " pounds</p>";
		output += "<p>BMI: " + bmi.toFixed(2) + "</p>";
		
		document.getElementById('output').innerHTML = output;
	}
};