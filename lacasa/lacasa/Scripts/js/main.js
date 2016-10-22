jQuery(document).ready(function ($) {
    //open the lateral panel
    $('.cd-btn').on('click', function (event) {
        event.preventDefault();
        var id = $(this).attr('id');
        if (id == "01") {
            $('#1').addClass('is-visible');
        }
        else {
            $('#2').addClass('is-visible');
        }
    });
    //close the lateral panel
    $('.cd-panel').on('click', function (event) {
        if ($(event.target).is('.cd-panel') || $(event.target).is('.cd-panel-close')) {
            event.preventDefault();

            var id = $(this).attr('id');

            if (id == "1") {
                $('#1').removeClass('is-visible');
            }
            else {
                $('#2').removeClass('is-visible');
            }

            //$(id).removeClass('is-visible');
            /*
			if (id == "01") {
			    $('#1').addClass('is-visible');
			}
			else {
			    $('#2').addClass('is-visible');
			}*/

        }
    });
});