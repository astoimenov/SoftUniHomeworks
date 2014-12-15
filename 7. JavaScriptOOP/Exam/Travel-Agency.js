function processTravelAgencyCommands(commands) {
    'use strict';

    Object.prototype.extends = function(parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    };

    Object.prototype.validateString = function(value, variableName) {
        if (typeof value !== 'string' || !value) {
            throw new Error('The ' + variableName + ' is required.');
        }
    };

    Object.prototype.validateNumber = function(value, variableName) {
        if (value < 0 || !value || isNaN(value)) {
            throw new Error('The ' + variableName + ' must be positive.');
        }
    };

    Object.prototype.validateDate = function(value, variableName) {
        if ((isNaN(value.getTime()) && value instanceof Date) || !value) {
            throw new Error('Invalid date: ' + variableName);
        }
    };

    var Models = (function() {
        var Destination = (function() {
            function Destination(location, landmark) {
                this.setLocation(location);
                this.setLandmark(landmark);
            }

            Destination.prototype.getLocation = function() {
                return this._location;
            };

            Destination.prototype.setLocation = function(location) {
                if (location === undefined || location === "") {
                    throw new Error("Location cannot be empty or undefined.");
                }

                this._location = location;
            };

            Destination.prototype.getLandmark = function() {
                return this._landmark;
            };

            Destination.prototype.setLandmark = function(landmark) {
                if (landmark === undefined || landmark === "") {
                    throw new Error("Landmark cannot be empty or undefined.");
                }

                this._landmark = landmark;
            };

            Destination.prototype.toString = function() {
                return this.constructor.name + ": " +
                    "location=" + this.getLocation() +
                    ",landmark=" + this.getLandmark();
            };

            return Destination;
        }());

        var Travel = (function() {

            function Travel(name, startDate, endDate, price) {
                if (this.constructor === Travel) {
                    throw new Error('Can\'t instantiate abstract class Travel.');
                }

                this.setEndDate(endDate);
                this.setName(name);
                this.setPrice(price);
                this.setStartDate(startDate);
            }

            Travel.prototype.getEndDate = function() {
                return this._endDate;
            };

            Travel.prototype.setEndDate = function(endDate) {
                this.validateDate(endDate, 'endDate');
                this._endDate = endDate;
            };

            Travel.prototype.getName = function() {
                return this._name;
            };

            Travel.prototype.setName = function(name) {
                this.validateString(name, 'name');
                this._name = name;
            };

            Travel.prototype.getPrice = function() {
                return this._price;
            };

            Travel.prototype.setPrice = function(price) {
                this.validateNumber(price, 'price');
                this._price = price;
            };

            Travel.prototype.getStartDate = function() {
                return this._startDate;
            };

            Travel.prototype.setStartDate = function(startDate) {
                this.validateDate(startDate, 'startDate');
                this._startDate = startDate;
            };

            Travel.prototype.toString = function() {
                var output = 'name=' + this.getName() + ',start-date=' + formatDate(this.getStartDate()) + ',end-date=' + formatDate(this.getEndDate()) + ',price=' + this.getPrice().toFixed(2);
                return output;
            };

            return Travel;
        }());

        var Excursion = (function() {

            function Excursion(name, startDate, endDate, price, transport) {
                Travel.call(this, name, startDate, endDate, price);
                this.setTransport(transport);
                this._destinations = [];
            }

            Excursion.extends(Travel);
            Excursion.prototype.getTransport = function() {
                return this._transport;
            };

            Excursion.prototype.setTransport = function(transport) {
                this.validateString(transport, 'transport');
                this._transport = transport;
            };

            Excursion.prototype.addDestination = function(destination) {
                this._destinations.push(destination);
            };

            Excursion.prototype.getDestinations = function() {
                return this._destinations;
            };

            Excursion.prototype.removeDestination = function(destination) {
                var index = this.getDestinations().indexOf(destination);
                if (index !== -1) {
                    this.getDestinations().splice(index, 1);
                } else {
                    throw new Error("Travel does not contain such destination.");
                }
            };

            Excursion.prototype.toString = function() {
                var output = ' * ' + this.constructor.name + ': ';
                output += Travel.prototype.toString.call(this);
                output += ',transport=' + this.getTransport() + "\n";
                output += ' ** Destinations: ';
                var dest = this.getDestinations();
                if (this._destinations.length > 0) {
                    var i = 0;
                    for (i = 0; i < dest.length - 1; i++) {
                        output += dest[i] + ';';
                    }

                    output += dest[dest.length - 1];
                } else {
                    output += '-';
                }

                return output;
            };

            return Excursion;
        }());

        var Vacation = (function() {

            function Vacation(name, startDate, endDate, price, location, accommodation) {
                Travel.call(this, name, startDate, endDate, price, location, accommodation);
                this.setLocation(location);
                this.setAccommodation(accommodation);
            }

            Vacation.extends(Travel);
            Vacation.prototype.getLocation = function() {
                return this._location;
            };

            Vacation.prototype.setLocation = function(location) {
                this.validateString(location, 'location');
                this._location = location;
            };

            Vacation.prototype.getAccommodation = function() {
                return this._accommodation;
            };

            Vacation.prototype.setAccommodation = function(accommodation) {
                if (accommodation !== undefined) {
                    this.validateString(accommodation, 'accommodation');
                }

                this._accommodation = accommodation;
            };

            Vacation.prototype.toString = function() {
                var output = ' * Vacation: ';
                output += Travel.prototype.toString.call(this);
                output += ',location=' + this.getLocation();
                if (this.getAccommodation() !== undefined) {
                    output += ',accommodation=' + this.getAccommodation();
                }

                return output;
            };

            return Vacation;
        }());

        var Cruise = (function() {

            var tr = 'cruise liner';

            function Cruise(name, startDate, endDate, price, startDock) {
                Excursion.call(this, name, startDate, endDate, price, tr, startDock);
                this.setStartDock(startDock);
            }

            Cruise.extends(Excursion);

            Cruise.prototype.getStartDock = function() {
                return this._startDock;
            };

            Cruise.prototype.setStartDock = function(startDock) {
                if (startDock !== undefined) {
                    this.validateString(startDock, 'startDock');
                }

                this._startDock = startDock;
            };

            Cruise.prototype.toString = function() {
                var output = Excursion.prototype.toString.call(this);
                return output;
            };

            return Cruise;
        }());

        return {
            Destination: Destination,
            Excursion: Excursion,
            Vacation: Vacation,
            Cruise: Cruise
        }
    }());

    var TravellingManager = (function() {
        var _travels;
        var _destinations;

        function init() {
            _travels = [];
            _destinations = [];
        }

        var CommandProcessor = (function() {

            function processInsertCommand(command) {
                var object;

                switch (command["type"]) {
                    case "excursion":
                        object = new Models.Excursion(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["transport"]);
                        _travels.push(object);
                        break;
                    case "vacation":
                        object = new Models.Vacation(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["location"], command["accommodation"]);
                        _travels.push(object);
                        break;
                    case "cruise":
                        object = new Models.Cruise(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["start-dock"]);
                        _travels.push(object);
                        break;
                    case "destination":
                        object = new Models.Destination(command["location"], command["landmark"]);
                        _destinations.push(object);
                        break;
                    default:
                        throw new Error("Invalid type.");
                }

                return object.constructor.name + " created.";
            }

            function processDeleteCommand(command) {
                var object,
                    index,
                    destinations;

                switch (command["type"]) {
                    case "destination":
                        object = getDestinationByLocationAndLandmark(command["location"], command["landmark"]);
                        _travels.forEach(function(t) {
                            if (t instanceof Models.Excursion && t.getDestinations().indexOf(object) !== -1) {
                                t.removeDestination(object);
                            }
                        });
                        index = _destinations.indexOf(object);
                        _destinations.splice(index, 1);
                        break;
                    case "excursion":
                    case "vacation":
                    case "cruise":
                        object = getTravelByName(command["name"]);
                        index = _travels.indexOf(object);
                        _travels.splice(index, 1);
                        break;
                    default:
                        throw new Error("Unknown type.");
                }

                return object.constructor.name + " deleted.";
            }

            function processListCommand(command) {
                return formatTravelsQuery(_travels);
            }

            function processAddDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }

                travel.addDestination(destination);
                return "Added destination to " + travel.getName() + ".";
            }

            function processRemoveDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }

                travel.removeDestination(destination);
                return "Removed destination from " + travel.getName() + ".";
            }

            function getTravelByName(name) {
                var i;

                for (i = 0; i < _travels.length; i++) {
                    if (_travels[i].getName() === name) {
                        return _travels[i];
                    }
                }

                throw new Error("No travel with such name exists.");
            }

            function getDestinationByLocationAndLandmark(location, landmark) {
                var i;

                for (i = 0; i < _destinations.length; i++) {
                    if (_destinations[i].getLocation() === location && _destinations[i].getLandmark() === landmark) {
                        return _destinations[i];
                    }
                }

                throw new Error("No destination with such location and landmark exists.");
            }

            function formatTravelsQuery(travelsQuery) {
                var queryString = "";

                if (travelsQuery.length > 0) {
                    queryString += travelsQuery.join("\n");
                } else {
                    queryString = "No results.";
                }

                return queryString;
            }

            function capitaliseFirstLetter(string) {
                return string.charAt(0).toUpperCase() + string.slice(1);
            }

            function filterTravels(travels, type, priceMin, priceMax) {
                var byType;
                if (type !== 'all') {
                    byType = travels.filter(function(travel) {
                        return travel.constructor.name === capitaliseFirstLetter(type);
                    });
                } else {
                    byType = travels;
                }

                var filtered = byType.filter(function(e) {
                    return priceMin <= e.getPrice() && e.getPrice() <= priceMax;
                });

                var sortedByDate = function(e1, e2) {
                    var dateOne = e1.getStartDate().valueOf(),
                        dateTwo = e2.getStartDate().valueOf();

                    if (dateOne === dateTwo) {
                        return e1.getName().localeCompare(e2.getName());
                    }
                    return dateOne - dateTwo;
                }

                var sortedByName = function(a, b) {
                    return a.getName() - b.getName();
                }

                var sorted = filtered.sort(sortedByDate).sort(sortedByName);

                if (sorted.length === 0) {
                    return 'No results.';
                }

                return sorted.join("\n");
            }

            function processFilterTravelsCommand(command) {
                return filterTravels(_travels, command['type'], command['price-min'], command['price-max']);
            }

            return {
                processInsertCommand: processInsertCommand,
                processDeleteCommand: processDeleteCommand,
                processListCommand: processListCommand,
                processAddDestinationCommand: processAddDestinationCommand,
                processRemoveDestinationCommand: processRemoveDestinationCommand,
                processFilterTravelsCommand: processFilterTravelsCommand
            }
        }());

        var Command = (function() {
            function Command(cmdLine) {
                this._cmdArgs = processCommand(cmdLine);
            }

            function processCommand(cmdLine) {
                var parameters = [],
                    matches = [],
                    pattern = /(.+?)=(.+?)[;)]/g,
                    key,
                    value,
                    split;

                split = cmdLine.split("(");
                parameters["command"] = split[0];
                while ((matches = pattern.exec(split[1])) !== null) {
                    key = matches[1];
                    value = matches[2];
                    parameters[key] = value;
                }

                return parameters;
            }

            return Command;
        }());

        function executeCommands(cmds) {
            var commandArgs = new Command(cmds)._cmdArgs,
                action = commandArgs["command"],
                output;

            switch (action) {
                case "insert":
                    output = CommandProcessor.processInsertCommand(commandArgs);
                    break;
                case "delete":
                    output = CommandProcessor.processDeleteCommand(commandArgs);
                    break;
                case "add-destination":
                    output = CommandProcessor.processAddDestinationCommand(commandArgs);
                    break;
                case "remove-destination":
                    output = CommandProcessor.processRemoveDestinationCommand(commandArgs);
                    break;
                case "list":
                    output = CommandProcessor.processListCommand(commandArgs);
                    break;
                case "filter":
                    output = CommandProcessor.processFilterTravelsCommand(commandArgs);
                    break;
                default:
                    throw new Error("Unsupported command.");
            }

            return output;
        }

        return {
            init: init,
            executeCommands: executeCommands
        }
    }());

    var parseDate = function(dateStr) {
        if (!dateStr) {
            return undefined;
        }

        var date = new Date(Date.parse(dateStr.replace(/-/g, ' ')));
        var dateFormatted = formatDate(date);
        if (dateStr != dateFormatted) {
            throw new Error("Invalid date: " + dateStr);
        }

        return date;
    }

    var formatDate = function(date) {
        var day = date.getDate();
        var monthName = date.toString().split(' ')[1];
        var year = date.getFullYear();
        return day + '-' + monthName + '-' + year;
    }

    var output = "";
    TravellingManager.init();

    commands.forEach(function(cmd) {
        var result;
        if (cmd != "") {
            try {
                result = TravellingManager.executeCommands(cmd) + "\n";
            } catch (e) {
                result = "Invalid command." + "\n";
            }

            output += result;
        }
    });

    return output;
}