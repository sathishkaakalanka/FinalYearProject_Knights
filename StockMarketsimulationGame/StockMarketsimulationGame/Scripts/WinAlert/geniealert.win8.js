/* 

This script and many more are also available free online at 
https://github.com/prakashm88/geniealert and http://code.google.com/p/geniealert/
Created by: Prakash Mohankumar | http://itechgenie.com/  

This product is distributed under the GNU General Public License Version 2 
(Read LICENSE.txt for more details).

*/

// variables to hold the title of the alert and image url.
var ALERT_TITLE = null ;
var IMAGE_URL = null ;

//method called when no methods arguments are called
function doNothing()
{
    window.status = "Do Nothing function called"  ;
}

// removes the custom alert from the DOM
function removeCustomAlert() {
  document.getElementsByTagName("body")[0].removeChild(document.getElementById("modalContainer"));
}

function createCustomAlert(alertText, buttonsNames, buttonCallFuncs) {
  // shortcut reference to the document object
  d = document;

// if the modalContainer object already exists in the DOM, bail out.
  if(d.getElementById("modalContainer")) return;

  // create the modalContainer div as a child of the BODY element
  mObj = d.getElementsByTagName("body")[0].appendChild(d.createElement("div"));
  mObj.id = "modalContainer";
   // make sure its as tall as it needs to be to overlay all the content on the page
  mObj.style.height = document.documentElement.scrollHeight + "px";
  mObj.style.zIndex = 9999999999999999;
  // create the DIV that will be the alert 
  alertObj = mObj.appendChild(d.createElement("div"));
  alertObj.id = "alertBox";

  // MSIE doesnt treat position:fixed correctly, so this compensates for positioning the alert
  if (d.all && !window.opera) alertObj.style.top = document.documentElement.scrollTop / 2 + "px";
  // center the alert box
  alertObj.style.left = (d.documentElement.scrollWidth - alertObj.offsetWidth)/2 + "px";
  alertObj.style.zIndex = 9999999999999999;
	headerContainer = alertObj.appendChild(d.createElement("div"));
	headerContainer.id = "headerContainer" ;

  // create an H1 element as the title bar
  h1 = headerContainer.appendChild(d.createElement("h1"));
  h1.appendChild(d.createTextNode(ALERT_TITLE));

    bodyCont = alertObj.appendChild(d.createElement("div"));
	bodyCont.id = "bodyContainer" ;
	bodyCont.style.zIndex = 9999999999999999;
  // create a paragraph element to contain the txt argument
  msgCon = d.createElement("div") ;
  msgCon.id = "msgconobj" ;
  msg = bodyCont.appendChild(msgCon);
  msg.innerHTML = alertText;
  
  btnDiva = bodyCont.appendChild(d.createElement("div"));
  btnDiva.id = "btnDiv";
  btnDiva.align= "center" ;

	for(var count=0; count < buttonsNames.length; count++)
	{
		btn = btnDiva.appendChild(d.createElement("a"));
		btn.id = buttonsNames[count];
		btn.setAttribute("class", "alertButtons");
		btn.appendChild(d.createTextNode(buttonsNames[count]));
		functionName = buttonCallFuncs[count] ;
		btn.href = "javascript:" + functionName + ";removeCustomAlert();" ;
        if(count == 0) btn.focus();
	}
	
	d.onkeyup=function(e){
		var e=window.event || e
		var keyunicode=e.keyCode? e.keyCode : e.charCode ;
		if(keyunicode == 27) removeCustomAlert() ;	
	}
}

function createCustomAlert(alertText, buttonsNames, buttonCallFuncs, alertStatus) {
    // shortcut reference to the document object
    d = document;
    //Select background Color
    var backColor = "green";
    switch (alertStatus) {
        case "success":
            backColor = "green";
            break;
        case "error":
            backColor = "red";
            break;
        case "info":
            backColor = "#0099FF";
            break;
        case "warning":
            backColor = "#FFFF00";
            break;
        default:
            backColor = "green";
            break;
    }

    // if the modalContainer object already exists in the DOM, bail out.
    if (d.getElementById("modalContainer")) return;

    // create the modalContainer div as a child of the BODY element
    mObj = d.getElementsByTagName("body")[0].appendChild(d.createElement("div"));
    mObj.id = "modalContainer";
    // make sure its as tall as it needs to be to overlay all the content on the page
    mObj.style.height = document.documentElement.scrollHeight + "px";
    mObj.style.zIndex = 9999999999999999;
    // create the DIV that will be the alert 
    alertObj = mObj.appendChild(d.createElement("div"));
    alertObj.id = "alertBox";

    // MSIE doesnt treat position:fixed correctly, so this compensates for positioning the alert
    if (d.all && !window.opera) alertObj.style.top = document.documentElement.scrollTop / 2 + "px";
    // center the alert box
    alertObj.style.left = (d.documentElement.scrollWidth - alertObj.offsetWidth) / 2 + "px";

    headerContainer = alertObj.appendChild(d.createElement("div"));
    headerContainer.id = "headerContainer";
    headerContainer.style.backgroundColor = backColor;
    if (alertStatus == "warning") {
        headerContainer.style.color = "#000000";
    }

    // create an H1 element as the title bar
    h1 = headerContainer.appendChild(d.createElement("h1"));
    h1.appendChild(d.createTextNode(ALERT_TITLE));
    if (alertStatus == "warning") {
        h1.style.color = "#000000";
    }
    bodyCont = alertObj.appendChild(d.createElement("div"));
    bodyCont.id = "bodyContainer";
    bodyCont.style.backgroundColor = backColor;
    if (alertStatus == "warning") {
        bodyCont.style.color = "#000000";
    }
    // create a paragraph element to contain the txt argument
    msgCon = d.createElement("div");
    msgCon.id = "msgconobj";
    msg = bodyCont.appendChild(msgCon);
    msg.innerHTML = alertText;
    if (alertStatus == "warning") {
        msg.style.color = "#000000";
    }
    btnDiva = bodyCont.appendChild(d.createElement("div"));
    btnDiva.id = "btnDiv";
    btnDiva.align = "center";
    btnDiva.style.backgroundColor = backColor;
    if (alertStatus == "warning") {
        btnDiva.style.color = "#000000";
    }
    for (var count = 0; count < buttonsNames.length; count++) {
        btn = btnDiva.appendChild(d.createElement("a"));
        btn.id = buttonsNames[count];
        btn.setAttribute("class", "alertButtons");
        btn.style.backgroundColor = backColor;
        if (alertStatus == "warning") {
            btn.style.color = "#000000";
            btn.style.borderColor = "#000000";
        }
        btn.appendChild(d.createTextNode(buttonsNames[count]));
        functionName = buttonCallFuncs[count];
        btn.href = "javascript:" + functionName + ";removeCustomAlert();";
        if (count == 0) btn.focus();
    }

    d.onkeyup = function (e) {
        var e = window.event || e
        var keyunicode = e.keyCode ? e.keyCode : e.charCode;
        if (keyunicode == 27) removeCustomAlert();
    }
}

// over-ride the alert method only if this a newer browser.
// Older browser will see standard alerts
// ARGS: 
// alertText - Text to be show in the alert box (not null)
// buttonsNames - Array of Buttons labels to be shown in the Alert Box (accepts null).
// buttonCallFuncs - Array of Function names to be called when the corresponding buttons are clicked  (accepts null).
// imageURL - URL for the image to be shown insode the alert box (accepts null).
// Eg: 
//		var buttonList = ["Yes", "No", "Cancel"] ;
//		var buttonListFunc = ["YesFunction()", "NoFunction()", "CancelFunction()"] ;
//		alert("Click on the following buttons to call the corresponding methods.", buttonList, buttonListFunc, "Alert Box", "images/alert.png") ;


if(document.getElementById) {
    window.alert = function (alertText, buttonsNames, buttonCallFuncs, alertBoxTitle, imageURL) {
        if (alertText) {
            if (buttonsNames == null && buttonCallFuncs == null) {
                buttonsNames = ["OK"];
                buttonCallFuncs = ["doNothing()"];
            }
            if (buttonsNames == null || buttonCallFuncs == null) {
                window.status = "Button names length and Functions does not match.";
                return false;
            }
            else if (buttonsNames.length != buttonCallFuncs.length) {
                window.status = "Button names length and Functions does not match.";
                return false;
            }
        }
        else {
            window.status = "Enter Proper Alert Message";
            return false;
        }
        if (alertBoxTitle == null) {
            ALERT_TITLE = "Alert!";
        }
        else {
            ALERT_TITLE = alertBoxTitle;
        }
        if (imageURL == null) {
            IMAGE_URL = "images/info.png";
        }
        else {
            IMAGE_URL = imageURL;
        }
        createCustomAlert(alertText, buttonsNames, buttonCallFuncs, imageURL);
    }

    window.alert = function (alertText, buttonsNames, buttonCallFuncs, alertBoxTitle, alertStatus, imageURL) {
        if (alertText) {
            if (buttonsNames == null && buttonCallFuncs == null) {
                buttonsNames = ["OK"];
                buttonCallFuncs = ["doNothing()"];
            }
            if (buttonsNames == null || buttonCallFuncs == null) {
                window.status = "Button names length and Functions does not match.";
                return false;
            }
            else if (buttonsNames.length != buttonCallFuncs.length) {
                window.status = "Button names length and Functions does not match.";
                return false;
            }
        }
        else {
            window.status = "Enter Proper Alert Message";
            return false;
        }
        if (alertBoxTitle == null) {
            ALERT_TITLE = "Alert!";
        }
        else {
            ALERT_TITLE = alertBoxTitle;
        }
        if (imageURL == null) {
            IMAGE_URL = "images/info.png";
        }
        else {
            IMAGE_URL = imageURL;
        }
        createCustomAlert(alertText, buttonsNames, buttonCallFuncs, alertStatus, imageURL);
    }
}
