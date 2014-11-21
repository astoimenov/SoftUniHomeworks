(function ($) {
    'use strict';
    $.extend($.fn, {
        swapClass: function (c1, c2) {
            var c1Elements = this.filter('.' + c1);
            this.filter('.' + c2).removeClass(c2).addClass(c1);
            c1Elements.removeClass(c1).addClass(c2);
            return this;
        },

        heightToggle: function (animated, callback) {
            animated ?
                    this.animate({ height: 'toggle' }, animated, callback) :
                    this.each(function () {
                        $(this)[$(this).is(':hidden') ? 'show' : 'hide']();
                        if (callback) {
                            callback.apply(this, arguments);
                        }
                    });
        },

        prepareBranches: function (settings) {
            if (!settings.prerendered) {
                this.filter(':last-child:not(ul)').addClass(CLASSES.last);
                this.filter((settings.collapsed ? '' : '.' + CLASSES.closed)
                    + ':not(.' + CLASSES.open + ')').find('>ul').hide();
            }

            return this.filter(':has(>ul)');
        },
        applyClasses: function (settings, toggler) {
            this.filter(':has(>ul):not(:has(>a))').find('>span').unbind('click.treeview')
                .bind('click.treeview', function (event) {
                if (this === event.target) {
                    toggler.apply($(this).next());
                }

            }).add($('a', this)).hoverClass();
            if (!settings.prerendered) {
                this.filter(':has(>ul:hidden)')
                .addClass(CLASSES.expandable)
                .replaceClass(CLASSES.last, CLASSES.lastExpandable);
                this.not(':has(>ul:hidden)')
                .addClass(CLASSES.collapsable)
                .replaceClass(CLASSES.last, CLASSES.lastCollapsable);
                var hitarea = this.find('div.' + CLASSES.hitarea);
                if (!hitarea.length) {
                    hitarea = this.prepend('<div class=\'' + CLASSES.hitarea + '\'/>')
                        .find('div.' + CLASSES.hitarea);
                }
                hitarea.removeClass().addClass(CLASSES.hitarea).each(function() {
                    var classes = '';
                    $.each($(this).parent().attr('class').split(' '), function() {
                        classes += this + '-hitarea ';
                    });

                    $(this).addClass(classes);
                });
            }

            this.find('div.' + CLASSES.hitarea).click(toggler);
        },
        treeview: function (settings) {
            settings = $.extend({
                cookieId: 'treeview'
            }, settings);
            if (settings.toggle) {
                var callback = settings.toggle;
                settings.toggle = function () {
                    return callback.apply($(this).parent()[0], arguments);
                };
            }

            function toggler() {
                $(this)
                .parent()
                .find('>.hitarea')
                .swapClass(CLASSES.collapsableHitarea, CLASSES.expandableHitarea)
                .swapClass(CLASSES.lastCollapsableHitarea, CLASSES.lastExpandableHitarea)
                .end()
                .swapClass(CLASSES.collapsable, CLASSES.expandable)
                .swapClass(CLASSES.lastCollapsable, CLASSES.lastExpandable)
                .find('>ul')
                .heightToggle(settings.animated, settings.toggle);
                if (settings.unique) {
                    $(this).parent()
                    .siblings()
                    .find('>.hitarea')
                    .replaceClass(CLASSES.collapsableHitarea, CLASSES.expandableHitarea)
                    .replaceClass(CLASSES.lastCollapsableHitarea, CLASSES.lastExpandableHitarea)
                    .end()
                    .replaceClass(CLASSES.collapsable, CLASSES.expandable)
                    .replaceClass(CLASSES.lastCollapsable, CLASSES.lastExpandable)
                    .find('>ul')
                    .heightHide(settings.animated, settings.toggle);
                }
            }

            this.data('toggler', toggler);
            this.addClass('treeview');
            var branches = this.find('li').prepareBranches(settings);
            branches.applyClasses(settings, toggler);
            
            return this;
        }
    });

    $.treeview = {};
    var CLASSES = ($.treeview.classes = {
        open: 'open',
        closed: 'closed',
        expandable: 'expandable',
        expandableHitarea: 'expandable-hitarea',
        lastExpandableHitarea: 'lastExpandable-hitarea',
        collapsable: 'collapsable',
        collapsableHitarea: 'collapsable-hitarea',
        lastCollapsableHitarea: 'lastCollapsable-hitarea',
        lastCollapsable: 'lastCollapsable',
        lastExpandable: 'lastExpandable',
        last: 'last',
        hitarea: 'hitarea'
    });
})($);
