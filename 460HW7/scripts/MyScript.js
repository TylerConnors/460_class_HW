// do an ajax call to get some numbers
$("#request").click(function () {
    var a = $("#sym").val();
    var b = document.getElementById("theradio").checked;
    var source = "/Home/StockGraph/";
    // get data in JSON format from our controller
    $.ajax({
        type: "GET",
        dataType: "json",
        url: source,
        data: {id:a, radio:b },
        success: displayData
    });
});

function displayData(data)
{
    console.log(data.Symbol);
    console.log(data.Company);
    console.log(data.ShowCompany);
    g = new Dygraph(
    document.getElementById("MyGraph"),
    data.Pagelink,
        {
        width: 400,
        height:300,
        series:
            {
                'Volume':
                {
                    axis: 'y2'
                }
            },
                axes:
                {
                    y:
                    {
                        drawGrid: false,
                        independentTicks: false
                    },
                    y2:
                    {
                        labelsKMB: true,
                        drawGrid: true,
                        independentTicks: true
                    }
                }
            }
        );

    if (data.ShowCompany)
    {
        $("#MyData").text("The company name and stock symbol is " + data.Company +".");
    }
    else
    {
        $("#MyData").text("The Stock symbol is: " + data.Symbol + ".");
    }
}