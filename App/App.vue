<template>
  <v-app id="app">
    <v-toolbar color="primary" dark fixed app>
      <v-toolbar-title>Application</v-toolbar-title>
    </v-toolbar>
    <v-content>
        <router-view/>
    </v-content>
    <v-footer color="primary" app>
      <span class="white--text">&copy; 2017</span>
    </v-footer>
  </v-app>
</template>

<script>
export default {
    name: 'app'
 }
</script>

<style lang="scss">
.application {
  font-family: 'Courier New', Courier, monospace;
}
</style>