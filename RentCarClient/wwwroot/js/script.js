function calculateDifference() {
    var pickupDate = new Date(document.getElementById("pickup-date").value);
    var returnDate = new Date(document.getElementById("return-date").value);

    if (isNaN(pickupDate.getTime()) || isNaN(returnDate.getTime())) {
        document.getElementById("result").textContent = "Please select both dates.";
        return;
    } else {
        document.getElementById("result").textContent = "";
    }

    var timeDiff = Math.abs(returnDate.getTime() - pickupDate.getTime());
    var daysDiff = Math.ceil(timeDiff / (1000 * 3600 * 24));

    var resultText = `Difference: ${daysDiff} day${daysDiff !== 1 ? 's' : ''}`;

    console.log(resultText)
    console.log(pickupDate)
    console.log(returnDate)
}

function openNav() {
    document.getElementById("mySidenav").style.width = "300px";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}