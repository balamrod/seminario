var page = "https://www.tomsplanner.com/public/seminario/";

$(document).ready(function () {
    $('#popup').click(function() {
        var $dialog = $('<div ></div>')
               .html('<iframe style="border: 0px; " src="' + page + '" width="100%" height="100%"></iframe>')
               .dialog({
                   autoOpen: false,
                   modal: true,
                   height: $(window).height() - 50,
                   width: $(window).width() - 50,
                   title: "Cronograma de Actividades"
               });
        $dialog.dialog('open');
    });
});



