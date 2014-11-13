function processRestaurantManagerCommands(commands) {
    'use strict';

    Object.prototype.extends = function (parent) {
        // old browsers support
        if (!Object.create) {
            Object.prototype.create = function (proto) {
                function F() { }
                F.prototype = proto;
                return new F;
            };
        }

        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    };

    Object.prototype.validateString = function (value, variableName) {
        if (typeof value !== 'string' || !value) {
            throw new Error('The ' + variableName + ' is required.');
        }
    };

    Object.prototype.validateNumber = function (value, variableName) {
        if (value < 0) {
            throw new Error('The ' + variableName + ' must be positive.');
        }
    };

    var RestaurantEngine = (function () {
        var _restaurants, _recipes;

        var globalConstants = {
            UNIT_GRAMS: 'g',
            UNIT_MILLILITERS: 'ml'
        };

        function initialize() {
            _restaurants = [];
            _recipes = [];
        }
        var Restaurant = (function () {
            function Restaurant(name, location) {
                this.setName(name);
                this.setLocation(location);
                this._restaurantRecipes = [];
            }
            Restaurant.prototype.getName = function () {
                return this._name;
            };
            Restaurant.prototype.setName = function (name) {
                this.validateString(name, 'name');
                this._name = name;
            };
            Restaurant.prototype.getLocation = function () {
                return this._location;
            };
            Restaurant.prototype.setLocation = function (location) {
                this.validateString(location, 'location');
                this._location = location;
            };
            Restaurant.prototype.addRecipe = function (recipe) {
                this._restaurantRecipes.push(recipe);
            };
            Restaurant.prototype.removeRecipe = function (recipe) {
                var index = this._restaurantRecipes.indexOf(recipe);
                this._restaurantRecipes.splice(index, 1);
            };
            Restaurant.prototype.printRestaurantMenu = function () {
                var drinksRecipes = '';
                var saladRecipes = '';
                var mainCourseRecipes = '';
                var dessertRecipes = '';
                var length = this._restaurantRecipes.length;
                var restaurantMenu = '***** ' + this.getName() + ' - ' + this.getLocation() + ' *****\n';
                var i = 0;
                
                if (length === 0) {
                    restaurantMenu += 'No recipes... yet\n';
                } else {
                    this._restaurantRecipes.sort(function (a, b) {
                        if (a.getName() < b.getName()) {
                            return -1;
                        }

                        if (a.getName() > b.getName()) {
                            return 1;
                        }

                        return 0;
                    });

                    for (i = 0; i < length; i += 1) {
                        var currentRecipe = this._restaurantRecipes[i];

                        if (currentRecipe instanceof Drink) {
                            drinksRecipes += currentRecipe.toString();
                        }

                        if (currentRecipe instanceof Salad) {
                            saladRecipes += currentRecipe.toString();
                        }

                        if (currentRecipe instanceof MainCourse) {
                            mainCourseRecipes += currentRecipe.toString();
                        }

                        if (currentRecipe instanceof Dessert) {
                            dessertRecipes += currentRecipe.toString();
                        }
                    }

                    if (drinksRecipes.length > 0) {
                        restaurantMenu += '~~~~~ DRINKS ~~~~~\n' + drinksRecipes;
                    }

                    if (saladRecipes.length > 0) {
                        restaurantMenu += '~~~~~ SALADS ~~~~~\n' + saladRecipes;
                    }

                    if (mainCourseRecipes.length > 0) {
                        restaurantMenu += '~~~~~ MAIN COURSES ~~~~~\n' + mainCourseRecipes;
                    }

                    if (dessertRecipes.length > 0) {
                        restaurantMenu += '~~~~~ DESSERTS ~~~~~\n' + dessertRecipes;
                    }
                }
                return restaurantMenu;
            };
            return Restaurant;
        }());

        var Recipe = (function () {
            function Recipe(name, price, calories, quantity, measurementUnit, timeToPrepare) {
                if (this.constructor === Recipe) {
                    throw new Error('Can\'t instantiate abstract class Recipe.');
                }
                this.setName(name);
                this.setPrice(price);
                this.setCalories(calories);
                this.setQuantity(quantity);
                this.setMeasurementUnit(measurementUnit);
                this.setTimeToPrepare(timeToPrepare);
            }
            Recipe.prototype.getName = function () {
                return this._name;
            };
            Recipe.prototype.setName = function (name) {
                this.validateString(name, 'name');
                this._name = name;
            };
            Recipe.prototype.getPrice = function () {
                return this._price.toFixed(2);
            };
            Recipe.prototype.setPrice = function (price) {
                this.validateNumber(price, 'price');
                this._price = price;
            };
            Recipe.prototype.getCalories = function () {
                return this._calories;
            };
            Recipe.prototype.setCalories = function (calories) {
                this.validateNumber(calories, 'calories');
                this._calories = calories;
            };
            Recipe.prototype.getQuantity = function () {
                return this._quantity;
            };
            Recipe.prototype.setQuantity = function (quantity) {
                this.validateNumber(quantity, 'quantity');
                this._quantity = quantity;
            };
            Recipe.prototype.getMeasurementUnit = function () {
                return this._measurementUnit;
            };
            Recipe.prototype.setMeasurementUnit = function (measurementUnit) {
                this._measurementUnit = measurementUnit;
            };
            Recipe.prototype.getTimeToPrepare = function () {
                return this._timeToPrepare;
            };
            Recipe.prototype.setTimeToPrepare = function (timeToPrepare) {
                this.validateNumber(timeToPrepare, 'timeToPrepare');
                this._timeToPrepare = timeToPrepare;
            };
            Recipe.prototype.toString = function () {
                var recipeString = '==  ' + this.getName() + ' == $' + this.getPrice() +
                    '\nPer serving: ' + this.getQuantity() + ' ' + this.getMeasurementUnit() +
                    ', ' + this.getCalories() + ' kcal' +
                    '\nReady in ' + this.getTimeToPrepare() + ' minutes';
                return recipeString;
            };
            return Recipe;
        }());

        var Drink = (function () {
            function Drink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
                Recipe.call(this, name, price, calories, quantity, globalConstants.UNIT_MILLILITERS, timeToPrepare);
                this.setIsCarbonated(isCarbonated);
            }
            Drink.extends(Recipe);
            Drink.prototype.setCalories = function (calories) {
                if (calories > 100) {
                    throw new Error('The drink calories must not be greater than 100.');
                }
                this._calories = calories;
            };
            Drink.prototype.setTimeToPrepare = function (timeToPrepare) {
                if (timeToPrepare > 20) {
                    throw new Error('The drink time to prepare must not be greater than 20');
                }
                this._timeToPrepare = timeToPrepare;
            };
            Drink.prototype.getIsCarbonated = function () {
                return this._isCarbonated;
            };
            Drink.prototype.setIsCarbonated = function (isCarbonated) {
                this._isCarbonated = isCarbonated;
            };
            Drink.prototype.toString = function () {
                var carbonated = this.getIsCarbonated() ? 'yes' : 'no';
                var drinkString = Recipe.prototype.toString.call(this) +
                    '\nCarbonated: ' + carbonated + "\n";
                return drinkString;
            };
            return Drink;
        }());

        var Meal = (function () {
            function Meal(name, price, calories, quantity, timeToPrepare, isVegan) {
                if (this.constructor === Meal) {
                    throw new Error('Can\'t instantiate abstract class Meal.');
                }
                Recipe.call(this, name, price, calories, quantity, globalConstants.UNIT_GRAMS, timeToPrepare);
                this.setIsVegan(isVegan);
            }
            Meal.extends(Recipe);
            Meal.prototype.getIsVegan = function () {
                return this._isVegan;
            };
            Meal.prototype.setIsVegan = function (isVegan) {
                this._isVegan = isVegan;
            };
            Meal.prototype.toggleVegan = function () {
                if (this._isVegan) {
                    this._isVegan = false;
                } else {
                    this._isVegan = true;
                }
            };
            Meal.prototype.toString = function () {
                if (this.getIsVegan()) {
                    return '[VEGAN] ' + Recipe.prototype.toString.call(this);
                }

                return Recipe.prototype.toString.call(this);
            };
            return Meal;
        }());

        var Dessert = (function () {
            function Dessert(name, price, calories, quantity, timeToPrepare, isVegan, withSugar) {
                Meal.call(this, name, price, calories, quantity, timeToPrepare, isVegan);
                this.setWithSugar(withSugar);
            }
            Dessert.extends(Meal);
            Dessert.prototype.getWithSugar = function () {
                return this._withSugar;
            };
            Dessert.prototype.setWithSugar = function (withSugar) {
                this._withSugar = withSugar === undefined ? true : withSugar;
            };
            Dessert.prototype.toggleSugar = function () {
                if (this._withSugar) {
                    this._withSugar = false;
                } else {
                    this._withSugar = true;
                }
            };
            Dessert.prototype.toString = function () {
                if (!this.getWithSugar()) {
                    return '[NO SUGAR] ' + Meal.prototype.toString.call(this) + "\n";
                }

                return Meal.prototype.toString.call(this) + "\n";
            };

            return Dessert;
        }());

        var MainCourse = (function () {
            function MainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
                Meal.call(this, name, price, calories, quantity, timeToPrepare, isVegan);
                this.setType(type);
            }

            MainCourse.extends(Meal);
            MainCourse.prototype.getType = function () {
                return this._type;
            };

            MainCourse.prototype.setType = function (type) {
                this._type = type;
            };

            MainCourse.prototype.toString = function () {
                var mainCourseString = Meal.prototype.toString.call(this) +
                    '\nType: ' + this.getType() + "\n";
                return mainCourseString;
            };

            return MainCourse;
        }());

        var Salad = (function () {
            function Salad(name, price, calories, quantity, timeToPrepare, containsPasta) {
                Meal.call(this, name, price, calories, quantity, timeToPrepare);
                this.setContainsPasta(containsPasta);
                this.setIsVegan(true);
            }

            Salad.extends(Meal);
            Salad.prototype.getContainsPasta = function () {
                return this._containsPasta;
            };

            Salad.prototype.setContainsPasta = function (containsPasta) {
                this._containsPasta = containsPasta;
            };

            Salad.prototype.toString = function () {
                var pasta = this.getContainsPasta() ? 'yes' : 'no';
                var saladString = Meal.prototype.toString.call(this) +
                    '\nContains pasta: ' + pasta + "\n";
                return saladString;
            };
            return Salad;

        }());

        var Command = (function () {
            function Command(commandLine) {
                this._params = [];
                this.translateCommand(commandLine);
            }

            Command.prototype.translateCommand = function (commandLine) {
                var self, paramsBeginning, name, parametersKeysAndValues;
                self = this;
                paramsBeginning = commandLine.indexOf('(');
                this._name = commandLine.substring(0, paramsBeginning);
                name = commandLine.substring(0, paramsBeginning);
                parametersKeysAndValues = commandLine
                    .substring(paramsBeginning + 1, commandLine.length - 1)
                    .split(';')
                    .filter(function (e) {
                        return true;
                    });
                parametersKeysAndValues.forEach(function (p) {
                    var split = p
                        .split('=')
                        .filter(function (e) {
                            return true;
                        });
                    self._params[split[0]] = split[1];
                });
            };

            return Command;
        }());

        function createRestaurant(name, location) {
            _restaurants[name] = new Restaurant(name, location);
            return 'Restaurant ' + name + ' created\n';
        }

        function createDrink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
            _recipes[name] = new Drink(name, price, calories, quantity, timeToPrepare, isCarbonated);
            return 'Recipe ' + name + ' created\n';
        }

        function createSalad(name, price, calories, quantity, timeToPrepare, containsPasta) {
            _recipes[name] = new Salad(name, price, calories, quantity, timeToPrepare, containsPasta);
            return 'Recipe ' + name + ' created\n';
        }

        function createMainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
            _recipes[name] = new MainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type);
            return 'Recipe ' + name + ' created\n';
        }

        function createDessert(name, price, calories, quantity, timeToPrepare, isVegan) {
            _recipes[name] = new Dessert(name, price, calories, quantity, timeToPrepare, isVegan);
            return 'Recipe ' + name + ' created\n';
        }

        function toggleSugar(name) {
            var recipe;
            if (!_recipes.hasOwnProperty(name)) {
                throw new Error('The recipe ' + name + ' does not exist');
            }

            recipe = _recipes[name];
            if (recipe instanceof Dessert) {
                recipe.toggleSugar();
                return 'Command ToggleSugar executed successfully. New value: ' + recipe._withSugar.toString().toLowerCase() + "\n";
            }

            return 'The command ToggleSugar is not applicable to recipe ' + name + "\n";            
        }

        function toggleVegan(name) {
            var recipe;
            if (!_recipes.hasOwnProperty(name)) {
                throw new Error('The recipe ' + name + ' does not exist');
            }
            recipe = _recipes[name];
            if (recipe instanceof Meal) {
                recipe.toggleVegan();
                return 'Command ToggleVegan executed successfully. New value: ' +
                    recipe._isVegan.toString().toLowerCase() + "\n";
            }
            return 'The command ToggleVegan is not applicable to recipe ' + name + "\n";
        }

        function printRestaurantMenu(name) {
            var restaurant;
            if (!_restaurants.hasOwnProperty(name)) {
                throw new Error('The restaurant ' + name + ' does not exist');
            }
            restaurant = _restaurants[name];
            return restaurant.printRestaurantMenu();
        }

        function addRecipeToRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;
            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error('The restaurant ' + restaurantName + ' does not exist');
            }

            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error('The recipe ' + recipeName + ' does not exist');
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.addRecipe(recipe);
            return 'Recipe ' + recipeName + ' successfully added to restaurant ' + restaurantName + "\n";
        }

        function removeRecipeFromRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;
            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error('The recipe ' + recipeName + ' does not exist');
            }
            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error('The restaurant ' + restaurantName + ' does not exist');
            }
            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.removeRecipe(recipe);
            return 'Recipe ' + recipeName + ' successfully removed from restaurant ' + restaurantName + "\n";
        }

        function executeCommand(commandLine) {
            var cmd, params, result;
            cmd = new Command(commandLine);
            params = cmd._params;
            switch (cmd._name) {
            case 'CreateRestaurant':
                result = createRestaurant(params.name, params.location);
                break;
            case 'CreateDrink':
                result = createDrink(params.name, parseFloat(params.price, 10), parseInt(params.calories, 10),
                    parseInt(params.quantity, 10), params.time, parseBoolean(params.carbonated));
                break;
            case 'CreateSalad':
                result = createSalad(params.name, parseFloat(params.price, 10), parseInt(params.calories, 10),
                    parseInt(params.quantity, 10), params.time, parseBoolean(params.pasta));
                break;
            case 'CreateMainCourse':
                result = createMainCourse(params.name, parseFloat(params.price, 10), parseInt(params.calories, 10),
                    parseInt(params.quantity, 10), params.time, parseBoolean(params.vegan), params.type);
                break;
            case 'CreateDessert':
                result = createDessert(params.name, parseFloat(params.price, 10), parseInt(params.calories, 10),
                    parseInt(params.quantity, 10), params.time, parseBoolean(params.vegan));
                break;
            case 'ToggleSugar':
                result = toggleSugar(params.name);
                break;
            case 'ToggleVegan':
                result = toggleVegan(params.name);
                break;
            case 'AddRecipeToRestaurant':
                result = addRecipeToRestaurant(params.restaurant, params.recipe);
                break;
            case 'RemoveRecipeFromRestaurant':
                result = removeRecipeFromRestaurant(params.restaurant, params.recipe);
                break;
            case 'PrintRestaurantMenu':
                result = printRestaurantMenu(params.name);
                break;
            default:
                throw new Error('Invalid command name: ' + cmdName);
            }
            return result;
        }

        function parseBoolean(value) {
            switch (value) {
            case 'yes':
                return true;
            case 'no':
                return false;
            default:
                throw new Error('Invalid boolean value: ' + value);
            }
        }
        return {
            initialize: initialize,
            executeCommand: executeCommand
        };
    }());
    // Process the input commands and return the results
    var results = '';
    RestaurantEngine.initialize();
    commands.forEach(function (cmd) {
        if (cmd !== '') {
            try {
                var cmdResult = RestaurantEngine.executeCommand(cmd);
                results += cmdResult;
            } catch (err) {
                results += err.message + "\n";
            }
        }
    });
    return results.trim();
}
// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------
(function () {
    var arr = [];
    if (typeof require === 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function (line) {
            arr.push(line);
        }).on('close', function () {
            console.log(processRestaurantManagerCommands(arr));
        });
    }
}());