function connectToHub() {

    if (validateForm()) {
        let url = new URL('https://localhost:44315/Home/ConnectToRoom?');

        let roomSelected = document.getElementById("room");

        let params = {
            user: document.getElementById("userName").value,
            room: roomSelected.options[roomSelected.selectedIndex].text
        }

        url.search = new URLSearchParams(params).toString();

        fetch(url).then(res => {
            console.log("Request complete! response:", res);
            location.href = url.href;
        }).catch(function (error) {
            console.log('request failed', error);
        });
    }

}

function validateForm() {
    if (document.getElementById("userName").value == ''
        || document.getElementById("room").value == '') {
        alert("Invalid Form.....");
        return false;
    }
    else {
        return true;
    }
}