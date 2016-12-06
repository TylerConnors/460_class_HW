// do an ajax call to get some numbers
    $(document).ready(function () {
        $("#request").click(function () {
            var source = "/Booty/Gimme/";
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
        //make the table header
        var MyTable = '<tr><th>FullName</th><th>Booty</th></tr>';
		//loop through the json and get the data back
        for(var i = 0; i <Data.length; i++)
        {
            MyTable += '<tr><td>';
            MyTable += Data[i].FirstName;
            MyTable += ' ';
            MyTable += Data[i].LastName;
            MyTable += '</td><td>';
            MyTable += Data[i].Booty;
            MyTable += '</td></tr>';
        }
        $("#ShowMyDamnValues").append(MyTable);
    }