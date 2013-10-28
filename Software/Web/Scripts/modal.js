var page = "actualizacion.aspx";

$(document).ready(function () {
    $('#popup').click(function() {
        var $dialog = $('<div ><button id="create-user">Create new user</button></div>')
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



