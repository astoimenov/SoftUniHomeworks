var Noty = (function () {
    function generate(type, text, time) {
        var n = noty({
            text: text,
            type: type,
            dismissQueue: true,
            layout: 'topCenter',
            closeWith: ['button'],
            theme: 'defaultTheme',
            maxVisible: 10,
            timeout: time
        });
    }

    function success(text) {
        generate('success', text, 5000);
    }

    function error(text) {
        generate('error', text, 5000);
    }

    return {
        success: success,
        error: error
    }
})();
