$(function () {
    $('[data-toggle="tooltip"]').tooltip()

 
})

$(document).ready(function () {
    //$(".js-example-basic-single form-control").select2();
    $("#seltec").select2({
        placeholder: "Select a state",
        allowClear: true
    });

});