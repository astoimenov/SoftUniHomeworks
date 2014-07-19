function variablesTypes(input) {
    var name = input[0];
    var nameType = typeof(name);
    var age = input[1];
    var ageType = typeof(age);
    var isMale = input[2];
    var isMaleType = typeof(isMale);
    var foods = input[3];
    var foodsType = typeof(foods);
    console.log('My name: ' + name + ' // type is ' + nameType + '\nMy age: ' + age + ' //type is ' + ageType + '\nI am male: ' + isMale + ' // type is ' + isMaleType + '\nMy favorite foods are: ' + foods + ' //type is ' + foodsType);
}

variablesTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']]);
