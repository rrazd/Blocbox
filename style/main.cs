/* variables */
/* resets */
*,
*:before,
*:after {
  box-sizing: border-box;
}
.greenButton {
  background-color: #53D998;
  box-shadow: 0px 3px 0px 0px rgba(57, 155, 108, 0.5);
  border-radius: 8px;
  border: 0;
}
.greenButton:hover {
  background-color: #45B57F;
  color: #ffffff;
}
.firstSection {
  height: 100%;
  background: #1f2222;
}
.logoLoginHolder a {
  float: right;
}
.logoLoginHolder {
  overflow: hidden;
}
.logoLoginHolder img {
  float: left;
  width: 89px;
}
.hero {
  color: #ffffff;
  position: relative;
  top: 40%;
  transform: translateY(-50%);
  -ms-transform: translateY(-50%);
  /* IE 9 */
  -webkit-transform: translateY(-50%);
}
.hero img {
  float: right;
  width: 100%;
  max-width: 600px;
  height: auto;
}
.hero div:nth-child(1) {
  vertical-align: middle;
  padding-right: 50px;
}
.hero div:nth-child(2) {
  vertical-align: top;
  padding-top: 50px;
}
.hero div > h1 {
  line-height: 38px;
}
.hero div > p {
  line-height: 27px;
  padding-bottom: 15px;
}
.hr {
  padding: 0;
  transform: translateY(-100%);
}
.hr hr {
  height: 7px;
  border: 0;
  margin: 0;
  background-color: #53d998;
}
.hr img {
  position: absolute;
  left: 50%;
}
.secondSection {
  padding-right: 220px;
  padding-left: 220px;
  color: #4d4d4b;
}
.secondSection img {
  width: 100%;
  height: auto;
  max-width: 400px;
}
.secondSection .row {
  padding-bottom: 75px;
}
.secondSection .row .col {
  vertical-align: middle;
}
.secondSection .row:nth-child(odd) .featureDescription {
  padding-left: 50px;
}
.secondSection .row:nth-child(even) .featureDescription {
  padding-right: 50px;
}
.secondSection .row:nth-child(even) img {
  float: right;
}
.secondSection span {
  color: #53d998;
  font-style: italic;
}
.fifthSection {
  background-color: #53d998;
  color: #ffffff;
  text-align: center;
}
.fifthSection h2 {
  font-style: italic;
}
.footer {
  padding: 10px 50px;
  font-size: 0.875em;
  background-color: #1f2222;
  color: white;
}
.footer a {
  border: 0;
}
.footer a:hover {
  color: #ffffff;
  background-color: #1f2222;
  text-decoration: underline;
}
.footer span:nth-child(1) {
  width: 10%;
  text-align: left;
}
.footer span:nth-child(2) {
  width: 80%;
  text-align: center;
}
.footer span:nth-child(3) {
  text-align: right;
  text-decoration: underline;
}
html,
body {
  height: 100%;
}
body {
  font-family: "Muli", Arial;
  font-size: 1em;
}
body > div {
  padding: 50px 100px;
}
h1 {
  font-size: 1.875em;
}
h2 {
  font-size: 1.12em;
}
.highlightText {
  color: #53d998;
}
a {
  font-size: 0.875em;
  text-decoration: none;
  border: 1px solid #ffffff;
  border-radius: 10px;
  padding: 10px 15px;
}
a:link,
a:visited,
a:hover,
a:active {
  color: #ffffff;
}
a:hover {
  background-color: #ffffff;
  color: #1f2222;
}
@media (min-width: 30em) {
  .row {
    width: 100%;
    display: table;
    table-layout: fixed;
  }
  .col {
    display: table-cell;
  }
}
