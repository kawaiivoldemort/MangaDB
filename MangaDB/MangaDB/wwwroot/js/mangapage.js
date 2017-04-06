var $jq = jQuery.noConflict();

$jq(document).ready(function() {
    //code to connect to DB
    stageOneDownload = function() {
        //code to download first json
        $jq.ajax({
            dataType: "json",
            url: "metadata",
            success: function (metadata) {
                $jq('#title').html(metadata.name);
                $jq("#titleOriginal").html(metadata.japaneseName);
                $jq("#author").html(metadata.author);
                $jq("#publisher").html(metadata.publisher);
            }
        });
    }
    /*
    stageTwoDownload = function() {
        //code to download chapter list
        var chapters = jq.parseJSON(stagetwodown);
        chapters.forEach(function(item) {
            
            var chRow = document.createElement("div");
            var chNumber = document.createElement("div");
            var chName = document.createElement("div");
            $js(chRow).addClass('row');
            $js(chNumber).addClass('col-md-2');
            $js(chName).addClass('col-md-4');
            $js(chRow).append(chNumber);
            $js(chRow).append(chName);
            
        }, this);
    }*/
    stageThreeDownload = function() {
        //code to download synopsis
        $jq.ajax({
            dataType: "json",
            url: "summary",
            success: function (metadata) {
                $jq("#summary").html(synopsis.summary);
            }
        });
    }
    stageOneDownload();
    stageThreeDownload();
})