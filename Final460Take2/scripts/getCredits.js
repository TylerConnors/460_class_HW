// do an ajax call to get some numbers
    $(document).ready(function () {
        $("#request").click(function () {
            var a = $("#Number").val();
            console.log(a);
            var source = "/Booty/Gimme/" + a;
            console.log(source);
            // get data in JSON format from our controller
            $.ajax({
                type: "GET",
                dataType: "json",
                url: source,
                success: displayData
            });
        });
    });

    function displayData(Data) 
    {
        console.log(Data);
        console.log(Data[2].Title);
        //make the table
        var MyTable = MyTable = '<tr><th>Title</th><th>Director</th></tr>';
        for(var i = 0; i <Data.length; i++)
        {
            MyTable += '<tr><td>';
            MyTable += Data[i].Title;
            MyTable += '</td><td>';
            MyTable += Data[i].DirectorName;
            MyTable += '</td></tr>';
        }
        $("#ShowTheTable").append(MyTable);
    }