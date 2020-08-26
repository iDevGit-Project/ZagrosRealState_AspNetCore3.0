! function (o) {
    "use strict";
    var r = function () {};
    r.prototype.init = function () {
        o("#world-map-markers").vectorMap({
            map: "world_en",
            normalizeFunction: "polynomial",
            hoverOpacity: .7,
            hoverColor: !1,
            backgroundColor: "#fff",
            color: "#f2f5f7",
            borderColor: "#bcbfc7",
            colors: {
                in: "#35b8e0",
                au: "#35b8e0",
                gl: "#35b8e0",
                us: "#35b8e0",
                sa: "#35b8e0"
            },
            borderColors: {
                in: "#35b8e0",
                au: "#35b8e0",
                gl: "#35b8e0",
                us: "#35b8e0",
                sa: "#35b8e0"
            }
        }), o("#usa").vectorMap({
            map: "usa_en",
            enableZoom: !0,
            showTooltip: !0,
            selectedColor: null,
            hoverColor: null,
            backgroundColor: "#fff",
            color: "#f2f5f7",
            borderColor: "#bcbfc7",
            colors: {
                mo: "#35b8e0",
                fl: "#35b8e0",
                or: "#35b8e0"
            },
            onRegionClick: function (o, r, e) {
                o.preventDefault()
            }
        }), o("#iran").vectorMap({
            map: "iran_ir",
            enableZoom: !0,
            showTooltip: !0,
            selectedColor: null,
            hoverColor: null,
            backgroundColor: "#fff",
            color: "#f2f5f7",
            borderColor: "#bcbfc7"
        }), o("#canada").vectorMap({
            map: "canada_en",
            enableZoom: !0,
            showTooltip: !0,
            selectedColor: null,
            hoverColor: null,
            backgroundColor: "#fff",
            color: "#f2f5f7",
            borderColor: "#bcbfc7"
        }), o("#germany").vectorMap({
            map: "germany_en",
            enableZoom: !0,
            showTooltip: !0,
            selectedColor: null,
            hoverColor: null,
            backgroundColor: "#fff",
            color: "#31ce77",
            borderColor: "#bcbfc7"
        })
    }, o.VectorMap = new r, o.VectorMap.Constructor = r
}(window.jQuery),
function (o) {
    "use strict";
    window.jQuery.VectorMap.init()
}();