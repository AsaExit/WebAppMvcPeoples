
function getLastPeople(actionUrl) {

    $.get(actionUrl, function (response) {
        console.log("response:", response);
        document.getElementById("result").innerHTML = response;
    });

}

function getPeopleList(actionUrl) {

    $.get(actionUrl, function (response) {
        console.log("response:", response);
        document.getElementById("result").innerHTML = response;
    });

}

function getLastPeopleJSON(actionUrl) {

    $.get(actionUrl, function (response) {
        console.log("JSON response:", response);
        document.getElementById("result").innerHTML = response;
    });

}