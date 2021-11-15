
function getLastCar(actionUrl) {

    $.get(actionUrl, function (response) {
        console.log("response:", response);
        document.getElementById("result").innerHTML = response;
    });

}

function getCarList(actionUrl) {

    $.get(actionUrl, function (response) {
        console.log("response:", response);
        document.getElementById("result").innerHTML = response;
    });

}

function getLastCarJSON(actionUrl) {

    $.get(actionUrl, function (response) {
        console.log("JSON response:", response);
        document.getElementById("result").innerHTML = response;
    });

}