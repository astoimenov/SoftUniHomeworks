function findYoungestPerson(people) {
    var sortedPeople = people.sort(function(a, b) {
        return a.age > b.age;
    });
    jsConsole.writeLine('The youngest person is ' + sortedPeople[0].firstname + ' ' + sortedPeople[0].lastname);
}
findYoungestPerson([{
    firstname: 'George',
    lastname: 'Kolev',
    age: 32
}, {
    firstname: 'Bay',
    lastname: 'Ivan',
    age: 81
}, {
    firstname: 'Baba',
    lastname: 'Ginka',
    age: 40
}]);
