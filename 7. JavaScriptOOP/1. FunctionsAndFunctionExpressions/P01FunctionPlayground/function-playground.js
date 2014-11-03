'use strict';

function myFunc() {
    if (arguments.length > 0) {
        console.log(
            'Number of arguments in' + myFunc.name + ' is ' + arguments.length
         );

        for (var key in arguments) {
            console.log(
                'Argument ' + key + ' is ' +
                typeof arguments[key] + ' (value = ' + arguments[key] + ')'
            );
        }
    } else {
        console.log(
            myFunc.name + '() is called without arguments'
        );
    }

    console.log(this);
}

myFunc();
myFunc(258, 'Peshko', true);
myFunc(3.5, false);

myFunc.call(null, 951, 'Goshkov', 'blaa');
myFunc.apply(null, [64, '99', 794318]);