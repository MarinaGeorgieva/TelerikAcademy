function checkIfBrowserIsMozilla(event, args) {
	var currentWindow = window,
		currentBrowser = currentWindow.navigator.appCodeName,
		isMozilla = (currentBrowser === "Mozilla");
	if (isMozilla) {
		alert("Yes");
	} else {
		alert("No");
	}
}