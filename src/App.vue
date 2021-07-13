<template>
  <div>Hello {{ value }}
      <p>Test update</p>
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
