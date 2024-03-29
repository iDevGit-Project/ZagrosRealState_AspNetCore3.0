! function (e) {
    "use strict";
    var t = function () {};
    t.prototype.createBasic = function (t) {
        return t.children("div").steps({
            headerTag: "h3",
            bodyTag: "section",
            transitionEffect: "slideLeft",
            onFinishing: function (t, i) {
                return console.log("Form has been validated!"), !0
            },
            onFinished: function (t, i) {
                console.log("فرم را می توان با استفاده از روش ارسال ارائه کرد. E.g. $('#basic-form').submit()"), e("#basic-form").submit()
            }
        }), t
    }, t.prototype.createVertical = function (t) {
        return t.steps({
            headerTag: "h3",
            bodyTag: "section",
            transitionEffect: "fade",
            stepsOrientation: "vertical"
        }), t
    }, t.prototype.init = function () {
        this.createBasic(e("#basic-form")), this.createVertical(e("#wizard-vertical"))
    }, e.FormWizard = new t, e.FormWizard.Constructor = t
}(window.jQuery),
function (t) {
    "use strict";
    window.jQuery.FormWizard.init()
}();