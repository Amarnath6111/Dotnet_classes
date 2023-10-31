<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspAssignmentOne.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <h1>Mobile Phones </h1>
    <select id="item">
        <option value="iphone">Iphone 11</option>
        <option value="oneplus">OnePLus 6t</option>
        <option value="oppo">Oppo f11</option>
    </select>
    <img id="itemImage" src="ModileImages/" alt="Mobile Image">
    <button id="showCostButton">Modile Cost</button>
    <label id="costLabel"></label>
    <script>
        const itemDropdown = document.getElementById("item");
        const itemImage = document.getElementById("itemImage");
        const showCostButton = document.getElementById("showCostButton");
        const costLabel = document.getElementById("costLabel");
        const itemImages = {
            iphone: "ModileImages/iphone.jpg",
            oneplus: "ModileImages/oneplus.jpg",
            oppo: "ModileImages/oppo.jpg"
        };

        item.addEventListener("change", function () {
            const selectedValue = item.value;
            itemImage.src = itemImages[selectedValue];
        });

        showCostButton.addEventListener("click", function () {
            const selectedValue = item.value;
            let cost = "";
            switch (selectedValue) {
                case "iphone":
                    cost = "INR 75000";
                    break;
                case "oneplus":
                    cost = "INR 45000";
                    break;
                case "oppo":
                    cost = "INR 22000";
                    break;
                default:
                    cost = "Invalid";
            }
            costLabel.textContent = "Cost: " + cost;
        });
    </script>
</body>
</html>
