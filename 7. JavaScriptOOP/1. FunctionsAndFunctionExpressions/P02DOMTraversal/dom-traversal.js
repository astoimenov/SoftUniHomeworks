function traverse(selector) {
    'use strict';

    var element = document.querySelector(selector);
    traverseElement(element, '');

    function traverseElement(node, spacing) {
        var elementAsString;
        spacing = spacing || "    ";

        elementAsString = spacing + node.nodeName.toLowerCase() + ':';

        if (node.hasAttribute('id')) {
            elementAsString += ' id="' + node.id;
        }
        if (node.hasAttribute('class')) {
            elementAsString += ' class="' + node.className + '"';
        }

        console.log(elementAsString);

        [].forEach.call(node.childNodes, function (child) {
            if (child.nodeType === 1) {
                traverseElement(child, spacing + "    ");
            }
        });
    };
}

var selector = ".birds";
traverse(selector);