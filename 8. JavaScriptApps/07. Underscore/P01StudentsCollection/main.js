(function () {

    $.getJSON('students.json', function (students) {
        var filteredStudents = _.filter(students, function (student) {
            return student.age >= 18 && student.age <= 24
        });

        var result = {
            filteredStudents: filteredStudents
        };

        var template = '{{#filteredStudents}}<div>{{firstName}} {{lastName}} - age: {{age}}</div>{{/filteredStudents}}';
        var output = Mustache.render(template, result) + '<br/>';

        filteredStudents = _.filter(students, function (student) {
            return (student.firstName.localeCompare(student.lastName) < 0);
        });

        result = {
            filteredStudents: filteredStudents
        };

        template = '{{#filteredStudents}}<div>{{firstName}} {{lastName}}</div>{{/filteredStudents}}';
        output += Mustache.render(template, result) + '<br/>';

        filteredStudents = _.chain(students)
            .where({country: 'Bulgaria'})
            .map(function (student) {
                return {
                    firstName: student.firstName,
                    lastName: student.lastName
                }
            }).value();
        filteredStudents.forEach(function (student) {
            student.json = JSON.stringify(student)
        });

        result = {
            filteredStudents: filteredStudents
        };

        template = '{{#filteredStudents}}<div>{{json}}</div>{{/filteredStudents}}';
        output += Mustache.render(template, result) + '<br/>';

        filteredStudents = _.last(students, 5);
        result = {
            filteredStudents: filteredStudents
        };

        template = '{{#filteredStudents}}<div>{{firstName}} {{lastName}}</div>{{/filteredStudents}}';
        output += Mustache.render(template, result) + '<br/>';

        filteredStudents = _.chain(students)
            .filter(function (student) {
                return (student.country !== 'Bulgaria' && student.gender === 'Male');
            }).first(3).value();

        result = {
            filteredStudents: filteredStudents
        };

        template = '{{#filteredStudents}}<div>{{firstName}} {{lastName}} - gender: {{gender}} - country: {{country}}</div>{{/filteredStudents}}';
        output += Mustache.render(template, result) + '<br/>';
        $('body').html(output);
    });
})();