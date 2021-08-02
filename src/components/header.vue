<template>
    <nav class="navbar navbar-expand-lg navbar-light bg-light container">
        <div>
            <router-link to="/" class="navbar-brand">Glances Agency</router-link>
        </div>
       
        <!--<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>-->

        <div class="collaose navbar-collapse" id="navbarSupportedContent">
            <ul class="nav navbar-nav ms-auto">
                <router-link to="/SignUp" activeClass="active" tag="li">Sign Up</router-link>
            </ul>

        </div>
    </nav>
</template>