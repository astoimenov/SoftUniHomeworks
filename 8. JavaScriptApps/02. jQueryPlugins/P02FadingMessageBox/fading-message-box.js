(function ($) {
    'use strict';
    $.fn.messageBox = function () {
        var $this = $(this);
        $this.append($('<div class="message">'));
        return this;
    };

    $.fn.success = function (text) {
        $('.message').addClass('success').html(text).fadeIn(1000).fadeOut(2000);
        return this;
    };

    $.fn.error = function (text) {
        $('.message').addClass('error').html(text).fadeIn(1000).fadeOut(2000);
        return this;
    };
}($));