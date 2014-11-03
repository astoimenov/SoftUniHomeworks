var domModule = (function () {
    'use strict';

    function appendChild(domElement, selector) {
        window.de = domElement;
        var child = document.querySelector(selector);
        domElement.appendChild(child);
    }

    function removeChild(parentSelector, childSelector) {
        var parent = de.querySelector(parentSelector);
        var child = de.querySelector(childSelector);
        parent.removeChild(child);
    }

    function addEvent(selector, eventHandler, event) {
        var target = document.querySelectorAll(selector);
        for (var i = 0; i < target.length; i++) {
            target[i].addHandlerdocu(eventHandler, event);
        }
    }

    function retrieveElements(selector) {
        var elements = de.querySelectorAll(selector);
        return elements;
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addEvent,
        retrieveElements: retrieveElements
    };
})();

var liElement = document.createElement("li");

domModule.appendChild(liElement, ".birds-list");
domModule.removeChild("ul.birds-list", "li:first-child");
domModule.addHandler("li.birds", 'click', function () { alert("I'm a bird!") });

var elements = domModule.retrieveElements(".bird");

console.log(liElement);
console.log(elements);