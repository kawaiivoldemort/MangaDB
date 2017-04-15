var $jq = jQuery.noConflict();
alert("moo");
$jq(document).ready(function() {
    alert("here");
    $("#userInfo").html("<div>octopus</div>");
});