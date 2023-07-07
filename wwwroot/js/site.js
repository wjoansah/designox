// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let open = false
const navToggle = document.getElementById('nav-toggle')
const navMenu = document.getElementById('nav-menu')
const menuIcon = document.getElementById('menu-icon')

const stateIcons = {
    opened: "/images/shared/mobile/icon-close.svg",
    closed: "/images/shared/mobile/icon-hamburger.svg"
}

navToggle.addEventListener('click', () => {
    open = !open
    navMenu.classList.toggle('hidden')
    menuIcon.src = open ? stateIcons.opened : stateIcons.closed
})
