// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const apiRootUrl = "https://localhost:7153/";

function getApiAjaxCall(url, data = "") {
    const apiUrl = apiRootUrl + url;
    return $.ajax({
        type: 'GET',
        url: apiUrl,
        dataType: 'json',
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (data) {
            return { data: data, isSuccess: true };
        },
        error: function (request, error) {
            debugger
            return { data: request, isSuccess: false };
        }
    });
}
