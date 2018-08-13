function printMessage()
{
    var x = 10;
    for (var i = 1; i <= x; i++) {
    console.log(i);
    }

   /* console.log("Hello"); */ /*this will print a message to the console*/

}

function add()
{
    /*read the data from the text boxes */
    /*using the DOM to get the element*/
    var num1 = parseInt(document.getElementById("num1").value); 
    var num2 = parseInt(document.getElementById("num2").value);
    {
    /* add the numbers */
    var result = num1 + num2;

    //show the result 
    alert(result); 
    /*  show the result on a paragraph <p> */
        document.getElementById("result").innerText = "result = " + result;
    }

}

function addToList()
{

    var itemName = document.getElementById("itemName").value;
    var quantity = document.getElementById("quantity").value;

    var shoppingList = document.getElementById("shoppingList");

    //create table
    var row = shoppingList.insertRow(1);

    //insert two cells
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);

    //add some text or data to cells
    cell1.innerHTML = itemName;
    cell2.innerHTML = quantity;
    
}