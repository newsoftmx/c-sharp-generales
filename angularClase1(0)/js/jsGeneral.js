$(function () {
    $("#ref").click(function () {
        animate(".demo", 'bounce');
        return false;
    });
});

/*
"setInterval" se ejecutará una y otra vez en intervalos de x segundos, 
en cambio, setTimeout se ejecutará una sola vez pasados x segundos.
*/

function animate(element_ID, animation) {
    $(element_ID).addClass(animation);
    var wait = window.setTimeout(function () {
        $(element_ID).removeClass(animation)
    }, 1300
    );
}

$(function () {
    $("#miidentificador").click(function () {
        animate(".tunombre", 'bounceInRight');
        return false;
    });
});

function animate(element_ID, animation) {
    $(element_ID).addClass(animation);
    var wait = window.setTimeout(function () {
        $(element_ID).removeClass(animation)
    }, 1300
    );
}