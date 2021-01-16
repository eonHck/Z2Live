"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/streamhub").build();

connection.on("TargetUrlResponse", function (url) {
    setTimeout(function () {
        if (url === "none") {
            $("#searchContainer").fadeOut();
            setTimeout(function () {
                $("#noResults").fadeIn();
            }, 500);
        }
        else {
            window.location.href = url;
        }
    }, 5000);
});

connection.start().then(function () {
    requestUrl();
    $("#searchContainer").fadeIn();
}).catch(function (err) {
    return console.error(err.toString());
});

function requestUrl() {
    connection.invoke("TargetUrlRequest").catch(function (err) {
        return console.error(err.toString());
    });
}

document.getElementById("searchAgain").addEventListener("click", function () {
    requestUrl()
    $("#noResults").fadeOut();
    setTimeout(function () {
        $("#searchContainer").fadeIn();
    }, 500);
    
});