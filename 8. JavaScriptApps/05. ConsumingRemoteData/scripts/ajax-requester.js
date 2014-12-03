var ajaxRequester = (function () {
    var PARSE_APP_ID = 'E1ZmmIAZCAY8o1z7523lUbwgvdTY3RFNTfuhbafi';
    var PARSE_REST_API_KEY = 'Mh9LKEdFxjtZGic11jZL2HSAXewF9sc10eRvLpap';

    var makeRequest = function (method, url, data, success, error) {
        $.ajax({
            url: url,
            type: method,
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            contentType: 'application/json',
            data: JSON.stringify(data) || undefined,
            success: success,
            error: error
        });
    };

    var makeGetRequest = function (url, success, error) {
        return makeRequest('GET', url, null, success, error);
    };

    var makePostRequest = function (url, data, success, error) {
        return makeRequest('POST', url, data, success, error);
    };

    var makePutRequest = function (url, data, success, error) {
        return makeRequest('PUT', url, data, success, error);
    };

    var makeDeleteRequest = function (url, success, error) {
        return makeRequest('DELETE', url, success, error);
    };

    return {
        get: makeGetRequest,
        post: makePostRequest,
        put: makePutRequest,
        delete: makeDeleteRequest
    }
}());