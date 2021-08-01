<template>
  <div>Hello {{ value }}
      <p>Test api connection</p>
  </div>
  
</template>

<script>
export default {
  name: "App",
  data() {
    return {
      value: "World"
    };
  }
};
</script>
