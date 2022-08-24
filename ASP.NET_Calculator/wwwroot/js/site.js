var screenInput = $("#screenInput");
var availableOperations = ['-', '+', '/', '*'];

$(document).ready(function () {
    screenInput.val('0');
})

function addNumber(number) {
    var val = screenInput.val();

    if (val == '0' && number != ',')
        val = '';
    else if (number == ',' && availableOperations.includes(val.slice(-1)))
        number = '0,';

    screenInput.val(val + number);

    setOperationBtnsAvailable(true);
}

function addOperation(operation) {
    screenInput.val(screenInput.val() + operation);
    setOperationBtnsAvailable(false);
}

function clearScreen() {
    screenInput.val('0');
    setOperationBtnsAvailable(true);
}

function getResult() {
    $.ajax({
        type: 'POST',
        url: "@Url.Action("Result", "Home")",
        data: {
            inputVal: screenInput.val()
        },
        success: function (data) {
            if (data.success)
                screenInput.val(data.result);
            else
                alert(data.message);
        },
        error: function (data) {
            alert(data.message);
        },
        dataType: "json"
    });
}


function setOperationBtnsAvailable(state) {
    $('.operation').prop('disabled', !state);
}