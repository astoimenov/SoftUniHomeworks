(function () {
    var index = 1;
	var container = $('#images-container');

    function previousSlide() {
        switch (index) {
	        case 1:
	            index = 3;
				container.children().hide();
	            $('#image1').fadeIn(1000);
	            break;
	        case 2:
	            index -= 1;
				container.children().hide();
	            $('#image2').fadeIn(1000);
	            break;
	        case 3:
	            index -= 1;
				container.children().hide();
	            $('#image3').fadeIn(1000);
	            break;
	        default:
	            $('#error-list').append($('<li>').html("Invalid Index"));
        }
    }

    function nextSlide() {
        switch (index) {
	        case 1:
	            index += 1;
				container.children().hide();
	            $('#image1').fadeIn(1000);
	            break;
	        case 2:
	            index += 1;
				container.children().hide();
	            $('#image2').fadeIn(1000);
	            break;
	        case 3:
	            index = 1;
				container.children().hide();
	            $('#image3').fadeIn(1000);
	            break;
	        default:
	            $('#error-list').append($('<li>').html("Invalid Index"));
        }
    }

    var intervalInMillisec = 5000;
    $(document).ready(function () {
        $('#button-left').on('click', previousSlide);
        $('#button-right').on('click', nextSlide);
        nextSlide();
        setInterval(function () {
            $('#button-right').trigger('click');
        }, intervalInMillisec);
    });
}());