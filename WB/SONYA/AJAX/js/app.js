export function loadContactListPage(n) {
  var oXML = new XMLHttpRequest();
  oXML.open("GET", `/src/json_${n}.txt`, true);
  oXML.onreadystatechange = function () {
    doneLoading(oXML);
  };
  oXML.send("");
}
function doneLoading(oXML) {
  if (oXML.readyState != 4) return;
  var json = eval("(" + oXML.responseText + ")");
  var table = document.getElementById("contactListTable");
  for (var i = table.childNodes.length - 1; i > 0; i--) {
    table.removeChild(table.childNodes[i]);
  }
  for (var i = 0; i < json.contacts.length; i++) {
    var tr = document.createElement("TR");
    var td1 = document.createElement("TD");
    var td2 = document.createElement("TD");
    var td3 = document.createElement("TD");
    tr.style.backgroundColor = i % 2 ? "#FFF" : "#E6E6E6";
    table.appendChild(tr);
    tr.appendChild(td1);
    tr.appendChild(td2);
    tr.appendChild(td3);
    td1.appendChild(document.createTextNode(json.contacts[i].firstname));
    td2.appendChild(document.createTextNode(json.contacts[i].lastname));
    td3.appendChild(document.createTextNode(json.contacts[i].phone));
  }
}
