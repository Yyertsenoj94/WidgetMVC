function getSubtypes() {
    
    $("#primary").change(function () {
        var this_type = $(this).val();

        $.ajax({
            type: "POST",
            url: '/Widget/LoadSubTypes', //calls the widget controller and the loadsubtypes method as a post function to the method.
            data: { type: this_type },
            success: successFunc,
            error: errorFunc
        });

        function successFunc(data) {
            var select = $("#subtype");
            select.empty(); //empty out the current subtype select option block 
            
            select.append($("<option/>", { //add instruction
                value: 0,
                text: "Select a subtype"
            }));
            for (let i = 0; i < data.length; i++) {
                console.log(data[i])
                select.append($("<option/>", { //for each item fetched, add the item to the option list
                    value: data[i],
                    text: data[i]
                }));
            }
        }

        function errorFunc() {
            console.log("Error")
        }
    });



}

getSubtypes()