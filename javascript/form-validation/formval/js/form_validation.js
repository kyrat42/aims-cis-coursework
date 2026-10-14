$(document).ready(function(){
	$('#first').focus();
	  $('#area').attr('disabled',true).css('backgroundColor','rgb(230,230,230)');
	
	$('#sign_up').validate({
		rules:{					//uses names to determine <input />
			lname: "required",	//alternative to class="required"
			email:{					
				required:true,
				email:true
			},//end email
			length:{
				min: 3,
				max: 15
			},//end length
			width:{
				min: 3,
				max: 15
			}//end width
		},//end rules
		messages:{
			email:{
				required:"Please enter your email.",
				email:"Not a valid e-mail."
			},//end email
			length:{
				min: "There is no way your office is that small.",
				max: "If your office is that big, you're too rich for our club.",
				decimal: "Please enter digits."
			},//end length
			width:{
				min: "There is no way your office is that small.",
				max: "If your office is that big, you're too rich for our club.",
				decimal: "Please enter digits."
			}//end width
		}//end messages
	});//end validate


  $('#width, #length').blur(function(){//the blur event triggers the calculation
      var length=$('#length').val(); //gets the value input into the length field
      var width=$('#width').val(); //gets the value input into the width field
      if(width >= 3 && length >= 3) {
		var area=length*width; //calculate area
		$('#area').val(area.toFixed(2)+" square feet"); //outputs to area text box
      }
  });//end blur





});//end ready()
