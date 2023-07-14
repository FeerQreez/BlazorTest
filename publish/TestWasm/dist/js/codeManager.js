window.codeManager = {
    renderCode: function (url) {

        var xhr = new XMLHttpRequest();
        xhr.open('GET', '/blazor-ui/source/index?path=/Pages' + url.replace(/-/g, '_') + '.razor');
        xhr.onload = function () {
            if (xhr.status === 200) {
                var snippetContainer = document.getElementById("codecontainer");
                snippetContainer.innerHTML = xhr.responseText;
                prettyPrint();
            }
            else {
                alert('Request failed.  Returned status of ' + xhr.status);
            }
        };
        xhr.send();
    },
    showCodeSection: function() {
        window.codeManager.toggleCodeSection(true);
    },
    hideCodeSection: function() {
        window.codeManager.toggleCodeSection(false);
    },
    toggleCodeSection: function (visible) {
        var codeSection = document.getElementsByClassName("code-sample-wrapper");

        if (codeSection && codeSection.length) {
            codeSection[0].style.display = visible ? "block" : "none";
        }
    }
}