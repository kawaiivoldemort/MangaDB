var $jq = jQuery.noConflict();

$jq(document).ready(function() {
    //code to connect to DB
    
    stageOneDownload = function() {
        //code to download first json, stored in stageonedown

        var metadata = jq.parseJSON(stageonedown);
        $jq('#title').html();
        $jq("#titleOriginal").html();
        $jq("#author").html();
        $jq("#publisher").html();
    }
    stageTwoDownload = function() {
        //code to download chapter list, stored in stagetwodown

        stagetwodown.forEach(function(item) {
            var chapter = jq.parseJSON(item);
            var chRow = document.createElement("div");
            var chNumber = document.createElement("div");
            var chName = document.createElement("div");
            $js(chRow).addClass('row');
            $js(chNumber).addClass('col-md-2');
            $js(chName).addClass('col-md-4');
            
        }, this);
    }
    stageThreeDownload = function() {
        //code to download synopsis
    }
})