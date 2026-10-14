// accordion.js

$(document).ready(function() {
	$('#main_content div').hide();
	
	$('#main_content h3').click(
		function() {
			$(this).next('div').toggle();
		}
	);
});