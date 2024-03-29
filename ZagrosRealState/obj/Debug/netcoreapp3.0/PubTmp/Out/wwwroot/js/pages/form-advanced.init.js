! function (i) {
    "use strict";
    var t = function () {};
    t.prototype.initSelect2 = function () {
        i('[data-toggle="select2"]').select2()
    }, t.prototype.initSwitchery = function () {
        i('[data-plugin="switchery"]').each(function (t, e) {
            new Switchery(i(this)[0], i(this).data())
        })
    }, t.prototype.initMaxLength = function () {
        i("input#defaultconfig").maxlength({
            warningClass: "badge badge-success",
            limitReachedClass: "badge badge-danger"
        }), i("input#thresholdconfig").maxlength({
            threshold: 20,
            warningClass: "badge badge-success",
            limitReachedClass: "badge badge-danger"
        }), i("input#alloptions").maxlength({
            alwaysShow: !0,
            separator: " out of ",
            preText: "You typed ",
            postText: " chars available.",
            validate: !0,
            warningClass: "badge badge-success",
            limitReachedClass: "badge badge-danger"
        }), i("textarea#textarea").maxlength({
            alwaysShow: !0,
            warningClass: "badge badge-success",
            limitReachedClass: "badge badge-danger"
        }), i("input#placement").maxlength({
            alwaysShow: !0,
            placement: "top-left",
            warningClass: "badge badge-success",
            limitReachedClass: "badge badge-danger"
        })
    }, t.prototype.initTimePicker = function () {
        i("#timepicker").timepicker({
            defaultTIme: !1,
            icons: {
                up: "mdi mdi-chevron-up",
                down: "mdi mdi-chevron-down"
            }
        }), i("#timepicker2").timepicker({
            showMeridian: !1,
            icons: {
                up: "mdi mdi-chevron-up",
                down: "mdi mdi-chevron-down"
            }
        }), i("#timepicker3").timepicker({
            minuteStep: 10,
            icons: {
                up: "mdi mdi-chevron-up",
                down: "mdi mdi-chevron-down"
            }
        })
    }, t.prototype.initColorPicker = function () {
        i(".colorpicker-default").colorpicker({
            format: "hex"
        }), i(".colorpicker-rgba").colorpicker()
    }, t.prototype.initInputMask = function () {
        i('[data-toggle="input-mask"]').each(function (t, e) {
            var a = i(e).data("maskFormat"),
                n = i(e).data("reverse");
            null != n ? i(e).mask(a, {
                reverse: n
            }) : i(e).mask(a)
        })
    }, t.prototype.initDateRangePicker = function () {
        i(".input-daterange-datepicker").daterangepicker({
            buttonClasses: ["btn", "btn-sm"],
            applyClass: "btn-success",
            cancelClass: "btn-light"
        }), i(".input-daterange-timepicker").daterangepicker({
            timePicker: !0,
            timePickerIncrement: 30,
            locale: {
                format: "MM/DD/YYYY h:mm A"
            },
            buttonClasses: ["btn", "btn-sm"],
            applyClass: "btn-success",
            cancelClass: "btn-light"
        }), i(".input-limit-datepicker").daterangepicker({
            format: "MM/DD/YYYY",
            minDate: "06/01/2018",
            maxDate: "06/30/2018",
            buttonClasses: ["btn", "btn-sm"],
            applyClass: "btn-success",
            cancelClass: "btn-light",
            dateLimit: {
                days: 6
            }
        }), i("#reportrange span").html(moment().subtract(29, "days").format("MMMM D, YYYY") + " - " + moment().format("MMMM D, YYYY")), i("#reportrange").daterangepicker({
            format: "MM/DD/YYYY",
            startDate: moment().subtract(29, "days"),
            endDate: moment(),
            minDate: "01/01/2017",
            maxDate: "12/31/2020",
            dateLimit: {
                days: 60
            },
            showDropdowns: !0,
            showWeekNumbers: !1,
            timePicker: !1,
            timePickerIncrement: 1,
            timePicker12Hour: !0,
            ranges: {
                Today: [moment(), moment()],
                Yesterday: [moment().subtract(1, "days"), moment().subtract(1, "days")],
                "Last 7 Days": [moment().subtract(6, "days"), moment()],
                "Last 30 Days": [moment().subtract(29, "days"), moment()],
                "This Month": [moment().startOf("month"), moment().endOf("month")],
                "Last Month": [moment().subtract(1, "month").startOf("month"), moment().subtract(1, "month").endOf("month")]
            },
            opens: "left",
            drops: "down",
            buttonClasses: ["btn", "btn-sm"],
            applyClass: "btn-success",
            cancelClass: "btn-light",
            separator: " to ",
            locale: {
                applyLabel: "Submit",
                cancelLabel: "Cancel",
                fromLabel: "From",
                toLabel: "To",
                customRangeLabel: "Custom",
                daysOfWeek: ["Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"],
                monthNames: ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"],
                firstDay: 1
            }
        }, function (t, e, a) {
            console.log(t.toISOString(), e.toISOString(), a), i("#reportrange span").html(t.format("MMMM D, YYYY") + " - " + e.format("MMMM D, YYYY"))
        })
    }, t.prototype.init = function () {
        this.initSelect2(), this.initSwitchery(), this.initMaxLength(), this.initTimePicker(), this.initColorPicker(), this.initInputMask(), this.initDateRangePicker()
    }, i.FormAdvanced = new t, i.FormAdvanced.Constructor = t
}(window.jQuery),
function (t) {
    "use strict";
    window.jQuery.FormAdvanced.init()
}();