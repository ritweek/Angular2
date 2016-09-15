var app;
(function (app) {
    var Greeter = (function () {
        function Greeter(greeting) {
            this.greeting = greeting;
        }
        Greeter.prototype.greet = function () {
            console.log(this.greeting);
            document.getElementById('content').textContent = this.greeting;
        };
        return Greeter;
    }());
    app.Greeter = Greeter;
})(app || (app = {}));
window.addEventListener('DOMContentLoaded', function () {
    var btn = document.getElementById('btnGreet');
    btn.addEventListener('click', function () {
        var name = document.getElementById('txtName').value;
        var greeter = new app.Greeter("Hello, " + name);
        greeter.greet();
    });
});
//# sourceMappingURL=app.js.map