$(function () {
    $("#ref").click(function () {
        animate(".miclase", 'bounce');
        return false;
    });
});
$(function () {
    $("#miidentificador").click(function () {
        animate(".tunombre", 'flash');
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