(function () {
    var body = document.body;
    var currentUrl = location.href;
    var cdnEnvironment = "";
    var telerikNavigationVersion = "stable";
    var productName = "blazor-ui";
    var urlAddress = "";
    var range = document.createRange();
    var navWrap = document.createElement("div");
    var documentFragment;

    //if (currentUrl.indexOf("localhost") === -1) {

    if (currentUrl.indexOf("kendobuild") !== -1) {
        cdnEnvironment = "uat";
    }

    urlAddress = "https://" + cdnEnvironment + "cdn.telerik-web-assets.com/telerik-navigation/" + telerikNavigationVersion + "/nav-" + productName + "-csa-abs-component.html";

    range.selectNode(body);

    navWrap.style.display = "none";
    navWrap.setAttribute("id", "navWrap");
    
    body.firstElementChild.prepend(navWrap);

    fetch(urlAddress)
        .then(function (response) {
            return response.text();
        })
        .then(function (html) {
            documentFragment = range.createContextualFragment(html);
            navWrap.appendChild(documentFragment);
        })
        .catch(function () {});
    //}
})();

window.navigation = {
    displayNavigation: function () {
        var body = document.body;
        var nav = document.querySelector("#navWrap nav");

        if (nav) {
            body.firstElementChild.prepend(nav);
        }
    }
}